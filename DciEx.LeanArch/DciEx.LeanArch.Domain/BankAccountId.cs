using DciEx.LeanArch.Infrastructure;

namespace DciEx.LeanArch.Domain
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
