namespace DciEx.LeanArch.Domain
{
    public class BankAccountImpl : BankAccount
    {
        #region BankAccount
        public BankAccountId Id { get; private set; }

        public Money Barance { get; private set; }

        public BankAccount Increase(Money money)
        {
            return new BankAccountImpl(this.Id, Barance + money);
        }

        public BankAccount Decrease(Money money)
        {
            return new BankAccountImpl(this.Id, Barance - money);
        }
        #endregion

        #region ICloneable
        public object Clone()
        {
            return new BankAccountImpl(this);
        }
        #endregion

        #region Constructor
        public BankAccountImpl(BankAccountId id) : this(id, Money.Zero())
        {
        }

        public BankAccountImpl(BankAccountId id, Money barance)
        {
            Id = id;
            Barance = barance;
        }

        BankAccountImpl(BankAccountImpl that)
        {
            Id = that.Id;
            Barance = (Money) that.Barance.Clone();
        }
        #endregion
    }
}


