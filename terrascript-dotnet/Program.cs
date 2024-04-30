using Newtonsoft.Json.Linq;
using System.Diagnostics;


var processInfo = new ProcessStartInfo
{
    FileName = "C:/Users/Rama/AppData/Local/Programs/Python/Python39/python.exe",
    Arguments = "C://Users//Rama//source//repos//terrascript-dotnet//terrascript_log.py ", // Pass any required arguments
    RedirectStandardOutput = true,
    UseShellExecute = false,
    CreateNoWindow = true
};

using (var process = new Process())
{
    process.StartInfo = processInfo;
    process.Start();

    // Read the output from the Python script
    string output = process.StandardOutput.ReadToEnd();
    process.WaitForExit();

    //output = "hello";
    Console.WriteLine(output);
      if (string.IsNullOrWhiteSpace(output))
    {
        Console.WriteLine("Python script output is empty.");
        return;
    }
}
