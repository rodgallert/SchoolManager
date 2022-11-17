namespace SchoolManager.Domain.Model
{
    public class Subject
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float SchoolHours { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }
        public virtual ICollection<Grade> Grades { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
