namespace Domain
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public User(int id, string userName, string email, string address)
        {
            Id = id;
            UserName = userName;
            Email = email;
            Address = address;
        }

        public override string ToString()
        {
            return $"User - {Id} - {UserName} - {Email} - {Address}";
        }

    }
}