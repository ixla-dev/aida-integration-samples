using System.Collections.Generic;
using Aida.Sdk.Mini.Model;

namespace Aida.Samples.Integration.UI.Model
{
    public class OcrExecutedMessage : WorkflowMessage
    {
        public string Hostname { get; set; } = "";
        public List<RuntimeOcrInspectionResult> Results { get; set; }
    }
}