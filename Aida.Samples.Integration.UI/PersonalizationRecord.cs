﻿using System.Collections.Generic;
using System.Linq;

namespace Aida.Samples.Integration.UI
{
    /// <summary>
    /// Container for the personalization of a single support
    /// </summary>
    public class PersonalizationRecord
    {
        public List<PersonalizationField> Fields { get; set; } = new();
        public override string ToString() => string.Join(" | ", Fields.Where(_ => _.Data is string).Select(f => $"{f.FieldName}'{f.Data}'"));
    }
}
