using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dto
{
    public class LoginResponse
    {
        public bool Fail { get; set; }
        public int StatusCode { get; set; }
        public Result result { get; set; }
        public int count { get; set; }
        public int responseCode { get; set; }
        public string responseMessage { get; set; }
    }

    public class Result
    {
        public int UserId { get; set; }
        public string Token { get; set; }
    }
}
