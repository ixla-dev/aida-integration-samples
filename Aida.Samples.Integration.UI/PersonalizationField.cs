namespace Aida.Samples.Integration.UI
{
    /// <summary>
    /// Container used for the association of a personalization field and its value
    /// </summary>
    public class PersonalizationField
    {
        public PersonalizationField(string fieldName, object data)
        {
            FieldName = fieldName;
            Data = data;
        }
        public string FieldName { get; set; }
        public object Data { get; set; }
    }
}
