namespace SchoolManager.Domain.Model
{
    public class Class
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public bool Active { get; set; }
        public Guid GradeId { get; set; }
        public virtual Grade Grade { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
