using WinFormsDotNetCore.IBusiness;
using System;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsDotNetCore.Forms
{
	public partial class Form1 : Form
	{
		private readonly ITest _test;

		public Form1(ITest test)
		{
			_test = test;
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var texto = _test.HelloWorld();
			label1.Text = texto;

			var testes = _test.GetAll();
			label2.Text = testes.FirstOrDefault()?.Nome;
		}
	}
}
