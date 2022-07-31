using System;
using System.Collections.Generic;
using System.Text;

namespace GuptaKirana.Models
{
    public class ResponseDTO
    {
        public bool IsSuccess { get; set; } = true;
        public ResultDTO Result { get; set; }
        public ErrorDTO Error { get; set; }
    }
}
