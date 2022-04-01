using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyInventoryTest.Model
{
    public class Mail
    {
        public long MailID { get; set; }
        public string SMTPHostname { get; set; }
        public long SMTPPortNumber { get; set; }
        public string SMTPUsername { get; set; }
        public string SMTPPassword { get; set; }
        public string SenderName { get; set; }
        public string AddressTo { get; set; }
 
        public string DefaultSubject { get; set; }
        public string DefaultMessage { get; set; }
    }
}
