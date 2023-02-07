using Proline.ClassicOnline.Resource;
using RPOnlineGame.Handlers;
using System.Threading.Tasks;

namespace RPOnlineGame
{
    public class Program : ResourceMainScript
    {
        public override async Task OnStart()
        {
            ConsoleWriteAction.SubscribeEvent();
            ConsoleWriteLineAction.SubscribeEvent();
            DeleteItemRequestAction.SubscribeEvent(); 
            ListItemsRequestAction.SubscribeEvent();
            PutItemRequestAction.SubscribeEvent();
            ReadFileAction.SubscribeEvent();
            WriteFileAction.SubscribeEvent();
        }
    }
}
