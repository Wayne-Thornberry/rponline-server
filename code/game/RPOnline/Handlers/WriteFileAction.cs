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
    public class WriteFileAction : ExtendedEvent
    {
        private static ExtendedEvent _event;

        public WriteFileAction() : base(EventNameDefinitions.SaveFileHandler, false)
        {

        }


        public static void SubscribeEvent()
        {
            if (_event == null)
            {
                _event = new WriteFileAction();
                _event.Subscribe();
            }
        }

        protected override object OnEventTriggered(Player player, params object[] args)
        {
            EngineAPI.WriteFile(args);
            return null;
        }
    }
}
