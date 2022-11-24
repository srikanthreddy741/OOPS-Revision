﻿using CommonLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interface
{
    public interface IUserBL
    {
        public UserModel userRegistration(UserModel model);
        public string UserLogin(LoginModel userLogin);
        public string ForgetPassword(string Email);

    }
}
