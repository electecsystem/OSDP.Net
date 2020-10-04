using System;
using System.Collections.Generic;
using System.Text;
using OSDP.Net.Messages;
using OSDP.Net.Model.ReplyData;
namespace OSDP.Net
{
    public class NAKException : Exception
    {
       
        public ErrorCode ErrorCode { get; protected set; }
        public string ErrorString { get; protected set; }
        public IEnumerable<byte> ExtraData { get; protected set; }
        internal NAKException(Reply reply)
        {
            var nak = Nak.ParseData(reply);
            ErrorCode = nak.ErrorCode;
            ErrorString = nak.ErrorString;
            ExtraData = nak.ExtraData;
        }

    }
}
