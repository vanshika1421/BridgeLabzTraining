using BusinessLayer.Interface;
using ModelLayer;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using ServiceLayer.Interface;
namespace BusinessLayer.Service
{

      

        public class UserBl : IUserBl
        {
            private readonly IUserRL _userRL;

            public UserBl(IUserRL userRL)
            {
                _userRL = userRL;
            }

            public RegistrationModel RegisterUserBL(RegistrationModel registrationModel)
            {
                return _userRL.RegisterUserRL(registrationModel);
            }
         public LoginModel LoginUserBL(LoginModel loginModel)
        {
             return _userRL.LoginUserRL(loginModel);
        }
    }


    
}
