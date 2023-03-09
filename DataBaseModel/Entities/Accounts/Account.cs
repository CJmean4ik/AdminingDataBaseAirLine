namespace DataBaseModel.Entities.Accounts
{
    public class Account
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public Cashier Cashier { get; set; }
    }
}
