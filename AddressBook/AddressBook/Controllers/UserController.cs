using BusinessLayer.Interface;
using CommonLayer.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;

namespace AddressBook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public IUserBL userBL;
        public UserController(IUserBL userBL)
        {
            this.userBL = userBL;
        }
        [HttpPost("Register")]
        public IActionResult userRegister(UserModel model)
        {
            try
            {
                var result = userBL.userRegistration(model);
                if (result != null)
                {
                    return Ok(new { success = true, message = "Registered", data = result });
                }
                else
                {
                    return BadRequest(new { success = false, message = "failed" });
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpPost("Login")]
        public IActionResult UserLogin(LoginModel model)
        {
            try
            {
                var result = userBL.UserLogin(model);
                if (result != null)
                {
                    return Ok(new { success = true, message = "login successfully", data = result });
                }
                else
                {
                    return BadRequest(new { success = false, message = "failed" });
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpPost("Forget")]
        public IActionResult ForgetPassword(string Email)
        {
            try
            {
                var result = userBL.ForgetPassword(Email);
                if (result != null)
                {
                    return Ok(new { success = true, message = "sent successfully", data = result });
                }
                else
                {
                    return BadRequest(new { success = false, message = "failed" });
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        [Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
        [HttpPut]
        [Route("ResetPassword")]
        public ActionResult ResetPassword(string Password, string ConfirmPassword)
        {
            try
            {
               // var Email = User.FindFirst(ClaimTypes.Email).Value.ToString();

                if (userBL.ResetPassword(Password, ConfirmPassword))
                {
                    return Ok(new { success = true, message = "Reset Password is Succesfull" });
                }
                else
                {
                    return BadRequest(new { success = false, message = "Reset Password Link Could Not Be Sent" });
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}