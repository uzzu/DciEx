using NUnit.Framework;

namespace DciEx.LeanArch.Domain
{
    [TestFixture]
    public class TransferContextTest
    {
        [Test]
        public void TestTransfer()
        {
            var from = new BankAccountImpl(new BankAccountId("A"), new Money(10));
            var to = new BankAccountImpl(new BankAccountId("B"), new Money(0));
            var result = new TransferContext(from, to).Transfer(new Money(10));
            Assert.AreEqual(0, (result.From as BankAccount).Barance.Value);
            Assert.AreEqual(10, (result.To as BankAccount).Barance.Value);
        }
    }
}
