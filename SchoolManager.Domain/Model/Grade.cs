namespace SchoolManager.Domain.Model
{
    public class Grade
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public ICollection<Subject> Subjects { get; set; }
        public ICollection<Class> Classes { get; set; }
    }
}
