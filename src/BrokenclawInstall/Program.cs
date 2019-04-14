using System;
using WixSharp;

// DON'T FORGET to update NuGet package "WixSharp".
// NuGet console: Update-Package WixSharp
// NuGet Manager UI: updates tab

namespace BrokenclawInstall
{
    class Program
    {
        static void Main()
        {
            var project = new Project("BrokenclawApp",
                              new Dir(@"%ProgramFiles%\StephenBayer\Brokenclaw",
                                  new File(@"Files\Docs\readme.txt")));

            project.GUID = new Guid("6fe30b47-2577-43ad-9095-1861ba25889b");
            //project.SourceBaseDir = "<input dir path>";
            project.OutDir = "build/msi";

            project.BuildMsi();
        }
    }
}