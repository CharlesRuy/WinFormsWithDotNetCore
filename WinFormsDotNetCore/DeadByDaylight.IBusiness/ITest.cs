using WinFormsDotNetCore.Entities;
using System.Collections.Generic;

namespace WinFormsDotNetCore.IBusiness
{
	public interface ITest
	{
		string HelloWorld();

		List<TestEntity> GetAll();
	}
}
