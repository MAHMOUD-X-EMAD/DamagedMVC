using System.ComponentModel.DataAnnotations;

namespace Final.Models
{
    public class Experience
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string JobTitle { get; set;}
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set;}
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set;}
        public string? Details  { get; set;}
        public bool isDeleted { get; set; }
    }
}
