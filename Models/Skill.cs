using System.ComponentModel.DataAnnotations;

namespace Final.Models
{
    public class Skill
    {

        public int Id { get; set; }
        public string Name { get; set; }
        [Range(1, 5)]
        public int Level { get; set; }
        public bool isDeleted { get; set; }
    }
}
