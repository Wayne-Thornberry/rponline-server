using CInputOutput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPOnlineCore.Parts
{
    public static partial class EngineAPI
    {
        public static void Write(object[] args)
        {
            var api = new CInputOutputAPI();
            api.Write(args);
        }

        public static void WriteLine(object[] args)
        { 
            var api = new CInputOutputAPI();
            api.WriteLine(args);
        }

        public static string ReadFile(object[] args)
        { 
            var api = new CInputOutputAPI();
            return api.ReadFile(args);
        }

        public static void WriteFile(object[] args)
        {

            var api = new CInputOutputAPI();
            api.WriteFile(args);
        }
    }
}
