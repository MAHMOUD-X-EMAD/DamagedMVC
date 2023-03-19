using System.ComponentModel.DataAnnotations;

namespace Final.Models
{
    public class Skill
    {

        public int Id { get; set; }
        public string Name { get; set; }
        [Range(20, 100)]
        public int Level { get; set; }
        public bool isDeleted { get; set; }
    }
}
