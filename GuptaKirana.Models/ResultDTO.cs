using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace GuptaKirana.Models
{
    public class ResultDTO
    {
        public Object Data { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}
