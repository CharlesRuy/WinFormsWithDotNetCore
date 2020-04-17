using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsDotNetCore.Entities
{
	[Table("Test")]
	public class TestEntity
	{
		[Key]
		public int Id { get; set; }
		[Column("Nome")]
		public string Nome { get; set; }
	}
}
