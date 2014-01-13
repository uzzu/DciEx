namespace DciEx.LeanArch.Domain
{
    public static class BankAccountTransferSupport
    {
        #region Sender
        internal static TransferContext.Result Send(this TransferContext.Sender sender, Money money, TransferContext.Receiver receiver)
        {
            var sender_ = sender as BankAccount;
            var receiver_ = receiver as BankAccount;
            var newFrom = sender_.Decrease(money);
            var newTo = receiver_.Increase(money);
            return new TransferContext.Result() { From = newFrom, To = newTo };
        }
        #endregion
    }
}
