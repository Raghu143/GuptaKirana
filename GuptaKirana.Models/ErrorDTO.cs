using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace GuptaKirana.Models
{
    public class ErrorDTO
    {
        public HttpStatusCode StatusCode { get; set; }
        public string Error { get; set; }
    }
}
