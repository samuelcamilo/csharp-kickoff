
namespace Entities
{
    public class TransactionEntity 
    {
        public long Id { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; }
        public double PaymentValue { get; set; }

        public List<TransactionEntity> Seed() 
        {
            TransactionEntity transaction1 = new TransactionEntity { Id = 1, PaymentDate = new DateTime(2022, 06, 21), PaymentMethod = "AA", PaymentValue = 2400.00 };
            TransactionEntity transaction2 = new TransactionEntity { Id = 2, PaymentDate = new DateTime(2022, 06, 18), PaymentMethod = "AB", PaymentValue = 100.00 };
            TransactionEntity transaction3 = new TransactionEntity { Id = 3, PaymentDate = new DateTime(2022, 06, 22), PaymentMethod = "AA", PaymentValue = 200.00 };
            TransactionEntity transaction4 = new TransactionEntity { Id = 4, PaymentDate = new DateTime(2022, 06, 10), PaymentMethod = "AB", PaymentValue = 500.0 };

            return new List<TransactionEntity>() { transaction1, transaction2, transaction3, transaction4 };
        }
    }
}