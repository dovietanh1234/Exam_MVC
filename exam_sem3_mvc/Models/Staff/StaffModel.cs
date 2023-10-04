using System.ComponentModel.DataAnnotations;

namespace exam_sem3_mvc.Models.StaffModel
{
    public class StaffModel
    {
        [Required(ErrorMessage = "Vui lòng nhập tên staff")]
        [MinLength(6, ErrorMessage = "Vui lòng nhập tối thiểu 6 ký tự")]
        [Display(Name = "Tên staff")]
        public string name { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên staff")]
        [MinLength(6, ErrorMessage = "Vui lòng nhập tối thiểu 6 ký tự")]
        [Display(Name = "Tên staff")]
        public string position { get; set; }

        [Required]
        public int department_id { get; set; }

    }
}
