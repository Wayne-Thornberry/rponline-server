using CitizenFX.Core;
using Newtonsoft.Json;
using Proline.Resource.Eventing;
using RPOnlineCore.Parts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = Proline.Resource.Console;

namespace RPOnlineGame.Handlers
{
    public class ConsoleWriteAction : ExtendedEvent
    {
        private static ExtendedEvent _event;

        public static void SubscribeEvent()
        {
            if (_event == null)
            {
                _event = new ConsoleWriteAction();
                _event.Subscribe();
            }
        }

        public ConsoleWriteAction() : base("ConsoleWriteHandler", false)
        {

        }
 
        protected override object OnEventTriggered(Player player, params object[] args)
        {
            EngineAPI.Write(args);
            return null;
        }
    }
}
