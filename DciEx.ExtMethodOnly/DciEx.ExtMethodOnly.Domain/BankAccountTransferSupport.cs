namespace DciEx.ExtMethodOnly.Domain
{
    public static class BankAccountTransferSupport
    {
        #region TransferContext
        public static TransferContext<BankAccount>.Result Transfer(this TransferContext<BankAccount> obj, Money money)
        {
            return obj._Sender.Send(money, obj._Receiver);
        }
        #endregion

        #region Sender
        internal static TransferContext<BankAccount>.Result Send(this TransferContext<BankAccount>.Sender sender, Money money, TransferContext<BankAccount>.Receiver to)
        {
            var newFrom = sender._.Decrease(money);
            var newTo = to.OnReceived(money);
            return new TransferContext<BankAccount>.Result() { From = newFrom, To = newTo };
        }
        #endregion

        #region Receiver
        internal static BankAccount OnReceived(this TransferContext<BankAccount>.Receiver receiver, Money money)
        {
            return receiver._.Increase(money);
        }
        #endregion
    }
}
