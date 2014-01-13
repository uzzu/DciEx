namespace DciEx.ExtMethodOnly.Infrastructure
{
    public interface Identity<T>
    {
        T Value { get; }
    }

    public static class StringIdentitySupport
    {
        public static bool Equals(this Identity<string> identity, Identity<string> that)
        {
            return identity.Value.Equals(that.Value);
        }
    }
}
