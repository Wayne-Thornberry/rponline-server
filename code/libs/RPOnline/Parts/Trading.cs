using CTrading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPOnlineCore.Parts
{
    public static partial class EngineAPI
    {
        public static void DeleteItem(object[] args)
        {
            var api = new CTradingAPI();
            api.DeleteItem(args); 
        }

        public static object ListItem()
        { 
            var api = new CTradingAPI();
            return api.ListItem(); 
        }

        public static void PutItem(object[] args)
        {
            var api = new CTradingAPI();
            api.PutItem(args);
        }
    }
}
