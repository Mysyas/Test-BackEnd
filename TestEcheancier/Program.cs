using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using TestEcheancier.Models;
using TestEcheancier.Services;

namespace TestEcheancier
{
	internal class Program
	{
		public static async Task<int> Main(string[] args)
		{
			Console.Write("Commencez la saisie\nEx: -d=01/01/2023 -f=31/12/2023 -n=6 -p=4 -m=1200\n");
			string text=Console.ReadLine();
            Arguments arguments = new ProgramArgsProcessor().Treat(text);
            //Arguments arguments = new ProgramArgsProcessor().Process(args);
            var services = ConfigureServices();

			var serviceProvider = services.BuildServiceProvider();

			// calls the Run method in App, which is replacing Main
			serviceProvider.GetService<App>().Run(arguments);

			return 0;
		}

		private static IServiceCollection ConfigureServices()
		{
			IServiceCollection services = new ServiceCollection();

			// required to run the application
			services.AddTransient<App>();
			return services;
		}
	}
}
