using System;
using System.Threading.Tasks;

namespace restApiYaniuk
{
  public class Application
    {
        private string clChoice = "";
        ConsimpleRestClient httpRestClient = new ConsimpleRestClient();
        TablePrinter printData = new TablePrinter();

        public async Task RunAsync()
        {
            Introduction();
            await ProgStart();
        }

        private void Introduction()
        {
            Console.WriteLine("Web Table demo");
            Console.WriteLine();
            Console.WriteLine("This program makes a web request and gets data, which put in the table.");
            Console.WriteLine();

            Console.WriteLine("By default used the link: https://tester.consimple.pro/");
            Console.WriteLine("At the current stage of development this only available request.");
            Console.WriteLine();
        }

        private async Task ProgStart()
        {
            while (clChoice != "end")
            {
                Console.WriteLine("Enter \"get\" to see table or \"end\" for exit");
                Console.WriteLine();

                clChoice = Console.ReadLine();
                Console.WriteLine();

                if (clChoice == "end")
                {
                    continue;
                }
                else if (clChoice == "get")
                {
                    var overallData = await httpRestClient.GetOverallData();
                    if (overallData == null) continue;
                    printData.Print(overallData);
                    Console.WriteLine();
                    Console.WriteLine("You may get another table in next selection menu.");
                }
                else Console.WriteLine("Wrong command: {0} !", clChoice);
            }
        }
    }
}
