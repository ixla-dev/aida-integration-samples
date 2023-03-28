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

        public JobTemplateItem() { }
        public JobTemplateItem(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }

    public class WorkflowItem
    {
        public string TypeName { get; set; }
        public string DisplayName { get; set; }
        public override string ToString() => TypeName + " - " + DisplayName;

        public WorkflowItem() { }
        public WorkflowItem(string typeName, string displayName)
        {
            TypeName = typeName;
            DisplayName = displayName;
        }
    }
}
