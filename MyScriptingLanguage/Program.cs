using LuaConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using LuaConnector;

namespace MyScriptingLanguage
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prm = new Program();
            luaConnector lua = new luaConnector();
            lua.addFunc("sayHello", prm);
            while (true)
            {
                string command = Console.ReadLine();
                if(command == "/shutdown")
                {
                    break;
                }
                lua.runLineOfCode(command);
            }
        }
        
        public void sayHello()
        {
            Console.WriteLine("say Hello");
        }
    }
}
