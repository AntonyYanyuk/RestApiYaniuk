using System.Threading.Tasks;

namespace restApiYaniuk
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            Application application = new Application();
           await application.RunAsync();       
        }
    }
}
