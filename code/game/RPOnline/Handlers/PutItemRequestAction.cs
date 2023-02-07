using CitizenFX.Core;
using Newtonsoft.Json;
using Proline.Resource.Eventing;
using System;
using System.Collections.Generic;
using System.Linq; 
using Pro.Trading.Client;
using System.Text;
using System.Threading.Tasks;
using RPOnlineCore.Parts;

namespace RPOnlineGame.Handlers
{
    public class PutItemRequestAction : ExtendedEvent
    {
        private static ExtendedEvent _event;

        public PutItemRequestAction() : base("PutItemRequestHandler", false)
        {
        }

        public static void SubscribeEvent()
        {
            if (_event == null)
            {
                _event = new PutItemRequestAction();
                _event.Subscribe();
            }
        }
         

        protected override object OnEventTriggered(Player player, params object[] args)
        {
            EngineAPI.PutItem(args);
            return null;
        }
    }
}
