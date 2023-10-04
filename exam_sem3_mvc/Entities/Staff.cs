using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace exam_sem3_mvc.Entities
{
	[Table("Staff")]
	public class Staff
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[StringLength(100)]
		public string name { get; set; }

		public string? position { get; set; }

		public int department_id { get; set; }

		[ForeignKey("department_id")]
		public Department department { get; set; }


	}
}
