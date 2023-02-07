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
    public class ListItemsRequestAction : ExtendedEvent
    {
        private static ExtendedEvent _event;

        public static void SubscribeEvent()
        {
            if (_event == null)
            {
                _event = new ListItemsRequestAction();
                _event.Subscribe();
            }
        }
         

        public ListItemsRequestAction() : base("ListItemsRequestHandler", true)
        {
        }

        protected override object OnEventTriggered(Player player, params object[] args)
        {
            return EngineAPI.ListItem();  
        }
    }
}
