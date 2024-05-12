using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBMSProject
{
    public interface IUserSignUpObserver
    {
        void NotifyNewUserSignUp(string username, string email);

    }
}