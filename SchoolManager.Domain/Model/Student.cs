namespace SchoolManager.Domain.Model
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Document { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string MotherName { get; set; }
        public string FatherName { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
        public Guid UserId { get; set; }
        public Guid ClassId { get; set; }
        public virtual User User { get; set; }
        public virtual Class Class { get; set; }
        public virtual ICollection<StudentActivity> Activities { get; set; }
    }
}
