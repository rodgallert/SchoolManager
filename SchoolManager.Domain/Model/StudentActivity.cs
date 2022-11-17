namespace SchoolManager.Domain.Model
{
    public class StudentActivity
    {
        public Guid Id { get; set; }
        public bool IsDelivered { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public float ReceivedGrade { get; set; }
        public Guid ActivityId { get; set; }
        public Guid StudentId { get; set; }
        public virtual Activity Activity { get; set; }
        public virtual Student Student { get; set; }
    }
}
