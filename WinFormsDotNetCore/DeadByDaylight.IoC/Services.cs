using WinFormsDotNetCore.Business;
using WinFormsDotNetCore.Data;
using WinFormsDotNetCore.IBusiness;
using WinFormsDotNetCore.IData;
using Microsoft.Extensions.DependencyInjection;

namespace WinFormsDotNetCore.IoC
{
	public static class Services
	{
		public static void ConfigureServices(ServiceCollection services)
		{
			/*=============== Adicionando Business ===============*/
			services
				.AddScoped<ITest, Test>();

			/*=============== Adicionando Data ===============*/
			services
				.AddSingleton<ITestData, TestData>();
		}
	}
}
