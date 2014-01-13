namespace DciEx.ExtMethodOnly.Domain
{
    partial class TransferContext<T>
    {
        public class Result
        {
            public T From { get; set; }
            public T To { get; set; }
        }
    }
}
