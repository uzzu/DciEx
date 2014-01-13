using DciEx.ExtMethodOnly.Infrastructure;

namespace DciEx.ExtMethodOnly.Domain
{
    public partial class TransferContext<T>
    {
        internal Sender _Sender { get; private set; }
        internal Receiver _Receiver { get; private set; }

        public TransferContext(T from, T to)
        {
            _Sender = new Sender() { _ = from };
            _Receiver = new Receiver() { _ = to };
        }
    }
}
