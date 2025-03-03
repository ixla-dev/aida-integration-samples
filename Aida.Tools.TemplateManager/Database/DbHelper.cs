using Npgsql;

namespace Aida.Tools.TemplateManager.Database;

public class DbHelper
{
    private NpgsqlConnection      _connection;
    private DbHelperConfiguration _configuration;
    public DbHelper(DbHelperConfiguration configuration) { _configuration = configuration; }


    public async Task SetSearchPathAsync(string searchPath)
    {
        await ExecuteNonQueryAsync(
            $"""
             set search_path = "{searchPath}"
             """
        );
    }

    public async Task ConnectAsync()
    {
        var connectionString = new NpgsqlConnectionStringBuilder
        {
            Username = _configuration.Username,
            Password = _configuration.Password,
            Host = _configuration.Host,
            Database = "ixla_iws",
        }.ToString();
        _connection = new NpgsqlConnection(connectionString);
        _connection.Open();
        await SetSearchPathAsync("IWS");
    }

    public async Task CloseAsync() => await _connection.CloseAsync();

    public async Task<int> ExecuteNonQueryAsync(string query, Dictionary<string, object> arguments = null)
    {
        await using var command = await CreateCommandAsync(query, arguments);
        return await command.ExecuteNonQueryAsync();
    }

    public async Task<int> ExecuteScalarAsync(string query, Dictionary<string, object> arguments)
    {
        await using var command = await CreateCommandAsync(query, arguments);
        return Convert.ToInt32(await command.ExecuteScalarAsync());
    }

    public async Task<List<T>> QueryAsync<T>(string query, Dictionary<string, object> arguments, Func<NpgsqlDataReader, T> parser)
    {
        await using var command = await CreateCommandAsync(query, arguments);
        await using var reader  = await command.ExecuteReaderAsync();
        var             result  = new List<T>();
        while (await reader.ReadAsync())
            result.Add(parser(reader));
        return result;
    }

    public async Task<NpgsqlCommand> CreateCommandAsync(string query, Dictionary<string, object>? arguments = null)
    {
        var command = _connection.CreateCommand();
        command.CommandText = query;

        if (arguments is null)
            return command;

        foreach (var p in arguments)
        {
            command.Parameters.AddWithValue(p.Key, p.Value);
        }

        try
        {
            await command.PrepareAsync();
            return command;
        }
        catch (Exception e)
        {
            Console.WriteLine(
                $"""
                 Failed to prepare query:
                 {query}
                 """
            );
            return null;
        }
    }


    public async Task<Dictionary<string, string>> GetColumnSchema(string table)
    {
        await using var command = await CreateCommandAsync(
            $"""
             select * from "{table}" limit 1;
             """
        );
        await using var reader = await command.ExecuteReaderAsync();
        return await GetRecordDataTypes(reader);
    }

    public async Task<Dictionary<string, string>> GetRecordDataTypes(NpgsqlDataReader reader)
    {
        var result    = new Dictionary<string, string>();
        var colSchema = await reader.GetColumnSchemaAsync();
        foreach (var c in colSchema)
        {
            result.Add(c.ColumnName, c.DataTypeName);
        }

        return result;
    }
}