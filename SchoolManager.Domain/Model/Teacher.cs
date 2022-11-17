namespace SchoolManager.Domain.Model
{
    public class Teacher
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }
    }
}
