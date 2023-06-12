namespace Bank
{
    class Customer
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Region { get; set; }
        public string Email { get; set; }
        public string Account { get; set; }
        public string Bank { get; set; }
        public int Balance { get; set; }

        public Customer(string Id, string Fn, string Cy, string Email, string Account, string Bank, int Balance)
        {
            this.Id = Id;
            this.FullName = Fn;
            this.Region = Cy;
            this.Email = Email;
            this.Account = Account;
            this.Bank = Bank;
            this.Balance = Balance;
        }
    }
}
