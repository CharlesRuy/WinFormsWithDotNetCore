using WinFormsDotNetCore.Entities;
using WinFormsDotNetCore.IData;
using System.Collections.Generic;
using System.Linq;

namespace WinFormsDotNetCore.Data
{
	public class TestData : ITestData
	{
		public List<TestEntity> GetAll()
		{
			using (var ctx = new WinFormsDotNetCoreContext())
			{
				return ctx.TestEntity.ToList();
			}
		}
	}
}
