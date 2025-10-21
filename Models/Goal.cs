namespace Bank.Models
{
    public class Goal
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public decimal TargetAmount { get; set; }
        public decimal CurrentAmount { get; set; }
        public decimal Progress => TargetAmount > 0 ? (CurrentAmount / TargetAmount) * 100 : 0;
        public DateTime? Deadline { get; set; }
        public bool IsCompleted => CurrentAmount == TargetAmount;
    }
}
