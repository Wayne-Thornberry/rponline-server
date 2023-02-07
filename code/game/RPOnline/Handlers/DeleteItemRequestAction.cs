using CitizenFX.Core;
using Pro.Trading.Client;
using Proline.Resource.Eventing;
using RPOnlineCore.Parts;
using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;

namespace RPOnlineGame.Handlers
{
    public class DeleteItemRequestAction : ExtendedEvent
    {
        private static ExtendedEvent _event;

        public static void SubscribeEvent()
        {
            if (_event == null)
            {
                _event = new DeleteItemRequestAction();
                _event.Subscribe();
            }
        }

        public DeleteItemRequestAction() : base("DeleteItemRequestHandler", true)
        {
        }

        protected override object OnEventTriggered(Player player, params object[] args)
        {
            EngineAPI.DeleteItem(args);
            return null;
        }
    }
}
