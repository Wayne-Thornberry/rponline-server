using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CInputOutput
{
    public class CInputOutputAPI
    {
        public void Write(object[] args)
        {
            try
            {
                if (args.Length > 0)
                {
                    var data = args[0].ToString();
                    Console.Write(data); 
                }
                else
                {
                    Console.WriteLine("Argument count does not match expected count");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            } 
        }

        public void WriteLine(object[] args)
        {
            try
            {

                if (args.Length > 0)
                {
                    var data = args[0].ToString();
                    Console.WriteLine(data); 
                }
                else
                {
                    Console.WriteLine("Argument count does not match expected count"); 
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            } 
        }

        public string ReadFile(object[] args)
        {
            try
            { 
                if (args.Length > 0)
                {
                    var argPath = args[0].ToString();
                    var LocalPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                    var DEFAULT_PATH = Path.Combine(LocalPath, "ProjectOnline");
                    var newPath = Path.Combine(DEFAULT_PATH, argPath);

                    string fileAndPath = newPath;
                    string currentDirectory = Path.GetDirectoryName(fileAndPath);
                    string fullPathOnly = Path.GetFullPath(currentDirectory);

                    if (!Directory.Exists(fullPathOnly))
                        return null;

                    var data = File.ReadAllText(newPath);
                    return data;
                }
                else
                {
                    Console.WriteLine("Argument count does not match expected count");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return null;
        }

        public void WriteFile(object[] args)
        {
            try
            { 
                if (args.Length > 0)
                {
                    var argPath = args[0].ToString();
                    var data = args[1].ToString();
                    var LocalPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                    var DEFAULT_PATH = Path.Combine(LocalPath, "ProjectOnline");
                    var newPath = Path.Combine(DEFAULT_PATH, argPath);

                    string fileAndPath = newPath;
                    string currentDirectory = Path.GetDirectoryName(fileAndPath);
                    string fullPathOnly = Path.GetFullPath(currentDirectory);

                    if (!Directory.Exists(fullPathOnly))
                        Directory.CreateDirectory(fullPathOnly);
                    File.WriteAllText(newPath, data); 
                }
                else
                {
                    Console.WriteLine("Argument count does not match expected count");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
