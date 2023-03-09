using System.ComponentModel.DataAnnotations;

namespace Final.Models
{
    public class PersonalInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        [RegularExpression ("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$")]
        public string Email { get; set; }
        [RegularExpression("/\r\n^01[0125][0-9]{8}$\r\n/\r\ngm")]
        public string Phone { get; set; }
        public string Photo { get; set; }
        public string JobTitle { get; set; }
        public bool isDeleted { get; set; }
    }
}
