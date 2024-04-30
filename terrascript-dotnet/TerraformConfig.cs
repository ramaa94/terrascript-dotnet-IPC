using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terrascript_dotnet;

public class TerraformConfig
{
    public List<string> Resources { get; set; }
    public Dictionary<string, string> Providers { get; set; }
    public Dictionary<string, object> Variables { get; set; }
    public Dictionary<string, string> Outputs { get; set; }
}
