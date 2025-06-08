namespace Money.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Amount { get; set; }
        public bool ConfirmedByA { get; set; }
        public bool ConfirmedByB { get; set; }
    }
}
