﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Token
    {

        private string token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.S5P0gam_EL6fTPJ2euFzqdDvhf0n8mkZPF_vHbGdbiE";

     public string GetToken( )
        {
            return token;
        }

    }
}
