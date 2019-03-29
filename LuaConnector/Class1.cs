using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLua;


namespace LuaConnector
{
    public class luaConnector
    {
        private Lua lua;

        public luaConnector()
        {
            lua = new Lua();
        }

        public void runLineOfCode(string code)
        {
            try
            {
                lua.DoString(code);
            }
            catch (Exception i)
            {
                Console.WriteLine(i);
            }
        }


        public bool addFunc(string func, object obj)
        {

            try
            {
                lua.RegisterFunction(func, obj, obj.GetType().GetMethod(func));
                return true;
            }
            catch (Exception i)
            {
                Console.Write(i.Message);
                Console.WriteLine("_error Script: func: " + func + "_class: " + obj);
                return false;
            }

            return false;
        }

    }
}
