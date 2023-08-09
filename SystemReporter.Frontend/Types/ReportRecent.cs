namespace SystemReporter.Frontend.Types
{
    public struct ReportRecent
    {
        public string FileName;
        public ReportType TemplateType;
        public string TemplateName;
        public bool UseFilter;
        public string FilterName;
        public bool UseCustomOutput;
        public string CustomOutput;
    }
}
