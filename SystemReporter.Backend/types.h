#pragma once

enum ReportType
{
    All,
    Summary,
    Hardware,
    Software,
    Benchmark,
    Custom
};

struct ReportRecent
{
	char FileName[128];
    ReportType TemplateType;
    char TemplateName[128];
    bool UseFilter;
    char FilterName[128];
    bool UseCustomOutput;
    char CustomOutput[260];
};