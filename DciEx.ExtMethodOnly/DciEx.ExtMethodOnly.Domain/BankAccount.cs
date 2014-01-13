using System;

namespace DciEx.ExtMethodOnly.Domain
{
    public interface BankAccount : ICloneable
    {
        BankAccountId Id { get; }
        Money Barance { get; }
        BankAccount Increase(Money money);
        BankAccount Decrease(Money money);
    }

    public static class BankAccountSupport
    {
        public static bool Equals(this BankAccount obj, BankAccount that)
        {
            return obj.Id.Equals(that.Id);
        }
    }
}
