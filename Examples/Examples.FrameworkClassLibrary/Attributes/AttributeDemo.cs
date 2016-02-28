using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.FrameworkClassLibrary.Attributes
{
    public class AttributeDemo
    {
        public static void Demo()
        {
            Logger.Log("excute only in debug mode");
            //Logger.OldMethod("old method");

            HelpAttribute help;
            #region using reflection to get attribute detail info
            foreach (var item in typeof(Logger).GetCustomAttributes(true))
            {
                help = item as HelpAttribute;
                if (help != null)
                {
                    Console.WriteLine("The description of Logger:{0}", help.Description);
                }
            }
            #endregion
        }
    }

    #region using the exsited Attribute in .net framework
    [Help("this is test of Attribute")]
    class Logger
    {
        [Conditional("DEBUG")]
        public static void Log(string msg)
        {
            Console.WriteLine(msg);
        }

        [Obsolete("This is a old method", true)]  //the method is obsolete with error, can't call it anymore
        public static void OldMethod(string msg)
        {
            Console.WriteLine(msg);
        }

    }

    #endregion

    #region using customized Attribute by yourself
    [AttributeUsage(AttributeTargets.Class)]
    public class HelpAttribute : Attribute
    {
        private string desc;
        public HelpAttribute(string desc)
        {
            this.desc = desc;
        }

        public string Description { get { return desc; } }

    }
    #endregion
}
