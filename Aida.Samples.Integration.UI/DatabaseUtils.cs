using System;
using System.Collections.Generic;
using System.Linq;
using Npgsql;

namespace Aida.Samples.Integration.UI
{
    /// <summary>
    /// Support class for Exchange Database interaction
    /// </summary>
    public static class DatabaseUtils
    {
        /// <summary>
        /// </summary>
        /// <param name="tableName">Name of the exchange table</param>
        /// <param name="connection">Database connection object</param>
        /// <param name="fields"></param>
        /// <returns></returns>
        public static NpgsqlCommand BuildInsertStatement(string tableName, NpgsqlConnection connection, List<PersonalizationField> fields)
        {
            var fieldList = string.Join(", ", fields.Select(_ => $@"""{_.FieldName}"""));
            var valuePlaceHolders = string.Join(", ", fields.Select(_ => $"@{_.FieldName}"));

            fieldList += ", job_status";
            valuePlaceHolders += ", @job_status";

            var correlationId = "job:" + Guid.NewGuid().ToString();
            var insert = $@"INSERT INTO ""public"".""{tableName}"" (""correlation_id"", {fieldList}) VALUES ( @correlation_id, {valuePlaceHolders})";
            var cmd = new NpgsqlCommand(insert, connection);

            foreach (var f in fields)
                cmd.Parameters.AddWithValue(f.FieldName, f.Data);
            cmd.Parameters.AddWithValue("@correlation_Id", correlationId);
            cmd.Parameters.AddWithValue("@job_status", "Waiting");
            cmd.Prepare();

            return cmd;
        }
    }
}