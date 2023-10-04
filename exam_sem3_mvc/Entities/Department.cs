using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace exam_sem3_mvc.Entities
{
	[Table("departments")]
	public class Department
	{
		[Key]
		public int id { get; set; }

		[Required]
		public string name_department { get; set; }

		public ICollection<Staff> staff { get; set; }

	}
}
