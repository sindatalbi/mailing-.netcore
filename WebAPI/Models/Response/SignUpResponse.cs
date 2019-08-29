using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models.Response
{
    public class SignUpResponse
    {
        public string fullname { get; private set; }
        public string Email { get; private set; }

        public SignUpResponse(string name, string email)
        {
            fullname = name;
            Email = email;


        }


    }
}
