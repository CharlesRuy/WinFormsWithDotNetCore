using WinFormsDotNetCore.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace WinFormsDotNetCore.Forms
{
	static class Program
	{
		[STAThread]
		static void Main()
		{
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			var services = new ServiceCollection();

			Services.ConfigureServices(services);

			/* =============== Adicionando Form ===============*/
			services
				.AddScoped<Form1>();

			using (ServiceProvider serviceProvider = services.BuildServiceProvider())
			{
				var form1 = serviceProvider.GetRequiredService<Form1>();
				Application.Run(form1);
			}
		}
	}
}
