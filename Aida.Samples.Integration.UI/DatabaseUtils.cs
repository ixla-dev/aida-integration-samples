using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using Npgsql;

namespace Aida.Samples.Integration.UI
{
    /// <summary>
    /// Support class for Exchange Database interaction
    /// </summary>
    public static class DatabaseUtils
    {
        private static int _correlationId = 0;
        /// <summary>
        /// </summary>
        /// <param name="tableName">Name of the exchange table</param>
        /// <param name="connection">Database connection object</param>
        /// <param name="fields"></param>
        /// <returns></returns>
        public static NpgsqlCommand BuildInsertStatement(string tableName, NpgsqlConnection connection, List<PersonalizationField> fields)
        {
            var fieldList         = string.Join(", ", fields.Select(f => $@"""{f.FieldName}"""));
            var valuePlaceHolders = string.Join(", ", fields.Select(f => $"@{f.FieldName}"));

            fieldList += ", job_status";
            valuePlaceHolders += ", @job_status";

            _correlationId++;
            var correlationId = $"job:{_correlationId:0000}";
            var insert        = $@"INSERT INTO {tableName} (""correlation_id"", {fieldList}) VALUES ( @correlation_id, {valuePlaceHolders})";
            var cmd           = new NpgsqlCommand(insert, connection);

            foreach (var f in fields)
                cmd.Parameters.AddWithValue(f.FieldName, f.Data);

            cmd.Parameters.AddWithValue("@correlation_Id", correlationId);
            cmd.Parameters.AddWithValue("@job_status", "Waiting");
            cmd.Prepare();

            return cmd;
        }

        public static NpgsqlCommand ClearTable(string tableName, NpgsqlConnection connection)
        {
            var delete  = $@"DELETE FROM {tableName};";
            var command = new NpgsqlCommand(delete, connection);
            command.Prepare();
            return command;
        }
    }
}