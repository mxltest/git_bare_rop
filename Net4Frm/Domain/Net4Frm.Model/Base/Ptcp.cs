namespace Net4Frm.Model
{
    public enum PtcpState
    {
        Success = 0,
        Failed = -1
    }

    public class Ptcp<T>
    {
        public PtcpState StatusFlag { get; set; }
        public string Message { get; set; }
        public T ReturnValue { get; set; }

        public Ptcp()
        {
            StatusFlag = PtcpState.Success;
            Message = null;
        }

        public Ptcp(PtcpState statusFlag, string message)
        {
            this.StatusFlag = statusFlag;
            this.Message = message;
        }

        public Ptcp(PtcpState statusFlag, T t)
        {
            this.StatusFlag = statusFlag;
            this.ReturnValue = t;
        }

        public Ptcp(PtcpState statusFlag, string message, T t)
        {
            this.StatusFlag = statusFlag;
            this.Message = message;
            this.ReturnValue = t;
        }
    }
}
