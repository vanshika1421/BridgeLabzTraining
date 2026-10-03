using ModelLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interface
{
    
        public interface IUserBl
        {
            RegistrationModel RegisterUserBL(RegistrationModel registrationModel);
            LoginModel LoginUserBL(LoginModel loginModel);  
        }

 
}
