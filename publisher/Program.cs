using azure_service_bus;
using System;
using System.Threading.Tasks;

namespace servicebus.app
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Starting Service");

            try
            {
                var bus = new AzureBusBaseService();

                await bus.SendMessageAsync();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
