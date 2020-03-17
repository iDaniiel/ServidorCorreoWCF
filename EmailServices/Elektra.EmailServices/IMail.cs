using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Elektra.EmailServices
{
    [ServiceContract]
    public interface IMail
    {
        [OperationContract]
        int SendEmail(string gmailUserAddress, string gmailUserPassword, string[] emailTo,
          string[] ccTo, string subject, string body, bool isBodyHtml, FileAttachment[] attachments);

    }
}
