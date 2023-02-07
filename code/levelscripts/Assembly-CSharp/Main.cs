using System.Threading.Tasks;
using System.Threading;
using CitizenFX.Core.Native;
using CitizenFX.Core;

namespace LevelScripts
{
    public class Main
    {

        public async Task Execute(object[] args, CancellationToken token)
        {
            //while (!token.IsCancellationRequested)
            //{ 
            //    var hash = API.GetHashKey("CREATE_AUTOMOBILE");
            //    Function.Call((Hash)hash, API.GetHashKey("jet"), 0f,0f,70f, 0f);
            //    Debug.WriteLine("VehicleSpawned");
            //    await BaseScript.Delay(20000);
            //}
        }
    }
}