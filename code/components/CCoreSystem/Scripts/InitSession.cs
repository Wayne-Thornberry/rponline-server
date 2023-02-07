
using Proline.ClassicOnline.EventQueue;
using System.Threading.Tasks;

namespace CCoreSystem.Scripts
{
    public class InitSession
    {
        public async Task Execute()
        { 
            var api = new CCoreSystemAPI();
            api.StartNewScript("Main");
        }
    }
}
