using WinFormsDotNetCore.Entities;
using System.Collections.Generic;

namespace WinFormsDotNetCore.IData
{
	public interface ITestData
	{
		List<TestEntity> GetAll();
	}
}
