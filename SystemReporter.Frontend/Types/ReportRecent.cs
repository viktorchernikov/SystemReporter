using System.Runtime.InteropServices;

namespace SystemReporter.Frontend.Types
{
    [StructLayout(LayoutKind.Sequential)]
    public struct ReportRecent
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string FileName;
        public ReportType TemplateType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string TemplateName;
        public bool UseFilter;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string FilterName;
        public bool UseCustomOutput;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string CustomOutput;
    }
}
