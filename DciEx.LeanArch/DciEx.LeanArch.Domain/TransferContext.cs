using DciEx.LeanArch.Infrastructure;

namespace DciEx.LeanArch.Domain
{
    public partial class TransferContext
    {
        Sender sender;
        Receiver receiver;

        public TransferContext(TransferContext.Sender from, TransferContext.Receiver to)
        {
            sender = from;
            receiver = to;
        }

        public TransferContext.Result Transfer(Money money)
        {
            return sender.Send(money, receiver);
        }
    }
}
