namespace MicroRabbit.Banking.Application.Models
{
    public class AccountTransfer
    {
        public int SourceAccount { get; set; }

        public int TargetAccount { get; set; }

        public decimal Amount { get; set; }
    }
}
