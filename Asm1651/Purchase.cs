namespace Asm1651
{
    abstract class Purchase
    {
        public int TotalAmount { get; set; }
    }
    class Cash : Purchase
    {
        public int PaidAmount { get; set; }

        public Cash(int paidAmount, int totalammount)
        {
            this.PaidAmount = paidAmount;
            this.TotalAmount = totalammount;
        }

        public override string? ToString()
        {
            return $"Total: {TotalAmount}, Paid: {PaidAmount}";
        }
    }
}

