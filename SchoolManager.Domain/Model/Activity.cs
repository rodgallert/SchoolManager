namespace SchoolManager.Domain.Model
{
    public class Activity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public float MaxGrade { get; set; }
        public bool Active { get; set; }
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        public DateTime? UpdateDate { get; set; }
        public Guid SubjectId { get; set; }
        public Guid TeacherId { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<StudentActivity> StudentActivities { get; set; }
    }
}
