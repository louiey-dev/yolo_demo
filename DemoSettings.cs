using System;
using System.IO;

namespace Yolo_Demo
{
    // Models and test data from assets in YoloDotNet.Tests
    static class DemoSettings
    {
        public static readonly string OUTPUT_FOLDER = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "YoloDotNet_Results");
    }
}
