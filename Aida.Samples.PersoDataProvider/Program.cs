using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.IO.Enumeration;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Client;
using Aida.Sdk.Mini.Model;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using Npgsql;
using Sharprompt;

namespace Aida.Samples.PersoDataProvider;

public class Program
{
    public record LayoutEntry(string DisplayName, string FilePath)
    {
    }

    public class PersoRecordField
    {
        public string Name { get; set; }
        public object Value { get; set; }
        public PersoRecordField(string name, object value)
        {
            Name = name;
            Value = value;
        }
    }

    public class PersoRecord
    {
        public List<PersoRecordField> Fields { get; set; } = new();
    }

    public static async Task Main(string[] args)
    {
        var ipAddress   = args[0].Trim();
        var aidaBaseUrl = $"http://{ipAddress}:5000";
        var client = new IntegrationApi(new Configuration
        {
            BasePath = aidaBaseUrl,
            Timeout = 3000
        });

        var response = await client.FindJobTemplatesAsync();
        var jobs     = response.Items;
        var job      = Prompt.Select("Select a job template", jobs, 5, null, j => j.Name);
        var jobId    = job.Id!.Value;

        var dbConfig = job.DataSourceConfiguration.GetNpgSqlDataSourceConfigurationDto();
        var tableDef = await client.GetDataExchangeTableDefinitionAsync(jobId);
        var fieldDes = await client.GetEntityDescriptorsByJobTemplateIdAsync(jobId);

        var connectionString = BuildConnectionString(ipAddress, dbConfig.ConnectionString);
        await InsertData(connectionString, tableDef, fieldDes);
    }


    public static string BuildConnectionString(string ipAddress, string connectionString)
    {
        var builder = new NpgsqlConnectionStringBuilder(connectionString)
        {
            Host = ipAddress
        };
        return builder.ToString();
    }

    public static async Task InsertData(string connectionString, DataExchangeTableDefinition tableDef, List<EntityDescriptor> entities, int count = 5)
    {
        var records = new List<PersoRecord>();
        for (var i = 0; i < count; i++)
        {
            var record = new PersoRecord();
            foreach (var e in entities)
            {
                if (e.ValueType == EntityFieldValueType.String)
                    record.Fields.Add(new PersoRecordField(e.EntityName, DBNull.Value));
            }

            records.Add(record);
        }

        var dbConnection = new NpgsqlConnection(connectionString);
        dbConnection.Open();
        var command = dbConnection.CreateCommand();
        command = BuildInsertStatement(records, command, tableDef);
        var affected = await command.ExecuteNonQueryAsync();
        Console.WriteLine($"Inserted {affected}");
    }

    public static NpgsqlCommand BuildInsertStatement(IEnumerable<PersoRecord> records, NpgsqlCommand command, DataExchangeTableDefinition tableDef)
    {
        var fields = records.First().Fields;

        var names = fields.Select(f => f.Name).ToList();
        names.Add("job_status");
        names.Add("correlation_id");

        var fieldList = string.Join(", ", fields.Select(f => $@"""{f.Name}"""));

        var recordIndex = 0;

        var valuePlaceholderList = new List<string>();
        foreach (var r in records)
        {
            recordIndex++;
            var valuePlaceHolders = string.Join($", ", fields.Select(f => $"@{f.Name}{recordIndex}"));
            valuePlaceHolders = $"({valuePlaceHolders})";
            valuePlaceholderList.Add(valuePlaceHolders);
            foreach (var field in r.Fields)
                command.Parameters.AddWithValue("@" + field.Name + recordIndex, field.Value);
            command.Parameters.AddWithValue("@job_status", "'Waiting'");
            command.Parameters.AddWithValue("@correlation_id", Guid.NewGuid().ToString());
        }

        var values = string.Join(", ", valuePlaceholderList);
        var insert = $"INSERT INTO {tableDef.TableName} ({fieldList}) VALUES {values}";

        command.CommandText = insert;
        command.Prepare();
        return command;
    }


    public class MachineConfigurator
    {
        private readonly IntegrationApi _api;
        public MachineConfigurator(IntegrationApi api) { _api = api; }

        public async Task CreateJobTemplate(string name, string description, WebhooksTargetDto webhooksTarget, List<LayoutEntry> frontLayouts, List<LayoutEntry> rearLayouts = null)
        {
            var result = await _api.CreateJobTemplateAsync(null, new CreateJobTemplateDto
            {
                Name = "TEST PERU",
                Description = "Test Job Template for Peru IDs",
                Type = "Laser"
            });
            var index = 0;
            foreach (var l in frontLayouts) await UploadLayoutFile(l.FilePath, l.DisplayName, "front");
            foreach (var l in rearLayouts) await UploadLayoutFile(l.FilePath, l.DisplayName, "rear");
        }
        public async Task<int> UploadLayoutFile(string filename, string layoutName, string cardSide)
        {
            var response = await _api.UploadLayoutFileAsync(layoutName, cardSide, "laser_1", new List<FileParameter>
            {
                new(File.OpenRead(filename))
            });
            return response.Id!.Value;
        }
        public async Task AssignLayoutToJobTemplate() { }
        public async Task CreateWebhookTarget() { }
        public async Task AssignWebhookTargetToJobTemplate() { }
    }
}