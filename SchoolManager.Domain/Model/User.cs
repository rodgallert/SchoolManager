namespace SchoolManager.Domain.Model
{
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
        public string RecoveryKey { get; set; }
        public Guid UserTypeId { get; set; }
        public virtual UserType UserType { get; set; }
    }
}
