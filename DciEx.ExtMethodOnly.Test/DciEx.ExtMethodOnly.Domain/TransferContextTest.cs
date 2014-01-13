using NUnit.Framework;

namespace DciEx.ExtMethodOnly.Domain
{
    [TestFixture]
    public class TransferContextTest
    {
        [Test]
        public void TestTransfer()
        {
            var from = new BankAccountImpl(new BankAccountId("A"), new Money(10));
            var to = new BankAccountImpl(new BankAccountId("B"), new Money(0));
            var result = new TransferContext<BankAccount>(from, to).Transfer(new Money(10));
            Assert.AreEqual(0, result.From.Barance.Value);
            Assert.AreEqual(10, result.To.Barance.Value);
        }
    }
}
