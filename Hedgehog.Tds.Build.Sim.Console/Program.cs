using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hedgehog.Tds.Build.Sim.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                switch (args[0])
                {
                    case "install":
                        InstallArgs installArgs = new InstallArgs(args);
                        InstallProcess installProcess = new InstallProcess();
                        installProcess.Execute(installArgs);
                        break;
                    case "delete":
                        DeleteArgs deleteArgs = new DeleteArgs(args);
                        DeleteProcess deleteProcess = new DeleteProcess();
                        deleteProcess.Execute(deleteArgs);
                        break;
                    default:
                        System.Console.WriteLine("No Command Found");
                        break;
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Error occured starting pipeline " + e);
            }

        }
    }
}
