﻿using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Encryption
{
    public class SecurityKeyHelper 
        //işin içinde şifreleme olan sistemlerde, bizim her seyi byte array formatında veriyor olmamız gerekiyor.
        //Yani basit bir string ile key olusturamıyoruz. 
        //Bu keylerin Asp.net Jwt servislerinin anlayacağı hale getirmemiz gerekiyor.
    {
        public static SecurityKey CreateSecurityKey(string securityKey)
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
        }
    }
}
