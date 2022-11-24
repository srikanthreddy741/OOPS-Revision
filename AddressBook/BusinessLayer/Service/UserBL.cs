﻿using BusinessLayer.Interface;
using CommonLayer.Model;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Service
{
    public class UserBL : IUserBL
    {
        public IUserRL userRL;
        public UserBL(IUserRL userRL)
        {
            this.userRL = userRL;
        }
        public UserModel userRegistration(UserModel model)
        {
            try
            {
                return userRL.userRegistration(model);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public string UserLogin(LoginModel userLogin)
        {
            try
            {
                return userRL.UserLogin(userLogin);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public string ForgetPassword(string Email)
        {
            try
            {
                return userRL.ForgetPassword(Email);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
