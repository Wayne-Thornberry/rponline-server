using Newtonsoft.Json;
using Proline.Resource.IO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CInputOutput.Scripts
{
    public class InitCore
    {
        private ConsoleWriteAction _consoleWriteAction;
        private ConsoleWriteAction _consoleWriteLineAction;
        private ReadFileAction _readFileAction;
        private WriteFileAction _writeFileAction;

        public async Task Execute()
        { 
            try
            {
                _consoleWriteAction = new ConsoleWriteAction();
                _consoleWriteLineAction = new ConsoleWriteAction();
                _readFileAction = new ReadFileAction();
                _writeFileAction = new WriteFileAction();

                _consoleWriteAction.Subscribe();
                _consoleWriteLineAction.Subscribe();
                _readFileAction.Subscribe();
                _writeFileAction.Subscribe();
            }
            catch (System.Exception e)
            {

            } 
        }


    }
}
