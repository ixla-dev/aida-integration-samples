namespace Aida.Samples.Integration.UI
{
    /// <summary>
    /// UI support class used to provide interaction with the ComboBox
    /// </summary>
    public class JobTemplateItem
    {
        public string Name;
        public string Description;
        public int Id;
        public override string ToString() => $"{Name} - {Description}";
    }
}
