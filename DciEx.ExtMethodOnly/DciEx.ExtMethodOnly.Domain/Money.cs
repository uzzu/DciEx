using System;

namespace DciEx.ExtMethodOnly.Domain
{
    public class Money : ICloneable
    {
        public int Value { get; private set; }

        #region Factory
        public static Money Zero()
        {
            return new Money(0);
        }
        #endregion

        #region Operator
        public static Money operator+(Money a, Money b)
        {
            return new Money(a.Value + b.Value);
        }

        public static Money operator-(Money a, Money b)
        {
            return new Money(a.Value - b.Value);
        }
        #endregion

        #region ICloneable
        public object Clone()
        {
            return new Money(this);
        }
        #endregion

        #region Constructor
        public Money(int value)
        {
            Value = value;
        }

        Money(Money that) : this(that.Value)
        {
        }
        #endregion
    }
}
