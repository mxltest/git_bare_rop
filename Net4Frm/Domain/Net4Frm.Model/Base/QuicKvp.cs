namespace Net4Frm.Model
{
    public enum QuickKvpState
    {
        Success = 0,
        Failed = -1
    }


    public class QuickKvp
    {
        public QuickKvpState Flag { get; set; }

        public string Message { get; set; }

        //public T ReturnValue { get; set; }

        public QuickKvp()
        {
            Flag = QuickKvpState.Success;
            Message = null;
        }

        public QuickKvp(QuickKvpState flag, string message)
        {
            this.Flag = flag;
            this.Message = message;
        }
    }
}
