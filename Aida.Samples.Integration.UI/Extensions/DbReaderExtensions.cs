using System;
using System.Data.Common;

namespace Aida.Samples.Integration.UI.Extensions
{
    public static class DbReaderExtensions
    {
        public static int? ReadNullableInt32(this DbDataReader reader, string field)
        {
            var ordinal = reader.GetOrdinal(field);
            return reader.IsDBNull(ordinal) ? null : reader.GetInt32(ordinal);
        }

        public static string ReadNullableString(this DbDataReader reader, string field)
        {
            var ordinal = reader.GetOrdinal(field);
            return reader.IsDBNull(ordinal) ? null : reader.GetString(ordinal);
        }

        public static DateTime? ReadNullableDateTime(this DbDataReader reader, string field)
        {
            var ordinal = reader.GetOrdinal(field);
            return reader.IsDBNull(ordinal) ? null : reader.GetDateTime(ordinal);
        }

        public static int ReadInt32(this DbDataReader reader, string field)
        {
            var ordinal = reader.GetOrdinal(field);
            return reader.GetInt32(ordinal);

        }

        public static string ReadString(this DbDataReader reader, string field)
        {
            var ordinal = reader.GetOrdinal(field);
            return reader.GetString(ordinal);

        }

        public static DateTime ReadDateTime(this DbDataReader reader, string field)
        {
            var ordinal = reader.GetOrdinal(field);
            return reader.GetDateTime(ordinal);
        }
    }
}
