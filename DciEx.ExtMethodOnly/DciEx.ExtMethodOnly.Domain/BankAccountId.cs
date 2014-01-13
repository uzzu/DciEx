using DciEx.ExtMethodOnly.Infrastructure;

namespace DciEx.ExtMethodOnly.Domain
{
    public class BankAccountId : Identity<string>
    {
        public string Value { get; private set; }

        public BankAccountId(string value)
        {
            Value = value;
        }
    }
}
