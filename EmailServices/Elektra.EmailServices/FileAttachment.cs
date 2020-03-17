using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.IO;

namespace Elektra.EmailServices
{
    [DataContract]
    public class FileAttachment
    {
        [DataMember]
        public string FileContentBase64 { get; set; }

        [DataMember]
        public FileInfo Info { get; set; }
    }
}