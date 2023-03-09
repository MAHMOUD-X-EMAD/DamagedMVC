namespace Final.Models
{
    public class UserData
    {
        public int Id { get; set; }
        public PersonalInfo PersonalInfo { get; set; }
        public string CoverLetter { get; set; }
        public virtual List<Skill> Skill { get; set; }
        public virtual List<Experience>? Experiences { get; set; }
        public virtual List<Project> Projects { get; set; }
        public virtual Links Links { get; set; }
        public List<CvTemplate> templates { get; set; }
        public bool isDeleted { get; set; }
    }
}
