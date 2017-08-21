using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net4Frm.Model.Base
{
   public class LogMessage
    {
        public string Description { get; set; }
        public string DeviceInfo { get; set; }
        public string EntityID { get; set; }
        public string EntitySchemeName { get; set; }
        public string StringForNewEntity { get; set; }
        public string StringForOldEntity { get; set; }
        public string UserID { get; set; }
    }
}
