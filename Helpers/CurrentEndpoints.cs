using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SmallApi.Helpers
{
    public static class CurrentEndpoints
    {
        public static Dictionary<string, MethodInfo> Endpoints { get; set; } = new();
    }
}
