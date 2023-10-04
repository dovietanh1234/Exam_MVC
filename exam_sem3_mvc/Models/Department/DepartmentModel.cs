using System;
using System.ComponentModel.DataAnnotations;
namespace exam_sem3_mvc.Models.Department
{
    public class DepartmentModel
    {
        [Required]
        public string name_department { get; set; }

    }
}
