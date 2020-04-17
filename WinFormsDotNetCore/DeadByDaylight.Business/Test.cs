using WinFormsDotNetCore.Entities;
using WinFormsDotNetCore.IBusiness;
using WinFormsDotNetCore.IData;
using System.Collections.Generic;

namespace WinFormsDotNetCore.Business
{
	public class Test : ITest
	{
		private readonly ITestData _testData;

		public Test(ITestData testData)
		{
			_testData = testData;
		}

		public string HelloWorld()
		{
			return "Hello World";
		}

		public List<TestEntity> GetAll()
		{
			return _testData.GetAll();
		}
	}
}
