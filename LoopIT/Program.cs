using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopIT
{
    class Program
    {
        static void Main(string[] args)
        {
            string strArgTwo = "dir";
            string strArgThree = "";

            if (args.Length == 0)
            {
                Console.WriteLine("Program requires at least one argument");
                Console.WriteLine("[1] - path to folder to loop");
                Console.WriteLine("[2] - target directory or file [dir,file] optional - default is dir");
                Console.WriteLine("[3] - directories to skip - can be a single value or list delimitted by commas");
            }
            else
            {
                if (args.Length >= 2)
                    strArgTwo = args[1];
                if (args.Length == 3)
                    strArgThree = args[2];

                StackLoopDirs sld = new StackLoopDirs();

                if (strArgTwo == "dir")
                    sld.TraverseTreeDirs(args[0], strArgThree);
                
                if (strArgTwo == "file")
                    sld.TraverseTreeFiles(args[0], strArgThree);
                
            }
        }
    }
}
