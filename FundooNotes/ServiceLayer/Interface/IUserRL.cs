using System;
using System.Collections.Generic;
using System.Text;
using ModelLayer;

namespace ServiceLayer.Interface
{
    public interface IUserRL
    {
        RegistrationModel RegisterUserRL(RegistrationModel registrationModel);
        LoginModel LoginUserRL(LoginModel loginModel);
    }
}
