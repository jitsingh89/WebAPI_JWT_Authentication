using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_JWT_Authentication.Models
{
    public class LoginRequest
    {
        public string Username { get; set; }

        public string Password { get; set; }
    }
}