using System;

namespace CouchLoverServer
{
	static class Program
    {
        [STAThread]
        static void Main()
        {
			Server server = new Server();
			server.Start(666);

			Console.WriteLine("Server is now listening!");
			Console.WriteLine("Press any key to exit.");
			Console.ReadKey();
		}
    }
}
