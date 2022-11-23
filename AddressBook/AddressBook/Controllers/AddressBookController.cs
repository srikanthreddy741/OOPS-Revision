﻿using BusinessLayer.Interface;
using CommonLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AddressBook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressBookController : ControllerBase
    {
        public IAddressBookBL addressBL;
        public AddressBookController(IAddressBookBL addressBL)
        {
            this.addressBL = addressBL;
        }
        [HttpPost("create")]
        public IActionResult Create(AddressBookModel model)
        {
            try
            {
                var result = addressBL.Create(model);
                if (result != null)
                {
                    return Ok(new { success = true, message = "AddressBook Created", data = result });
                }
                else
                {
                    return BadRequest(new { success = false, message = "AddressBook is Invalid" });
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpGet("Get")]
        public IActionResult GetAddressBook()
        {
            try
            {
                var result = addressBL.GetAddressBook();
                if (result != null)
                {
                    return Ok(new { success = true, message = "Addressbook retrived successfully", data = result });
                }
                else
                {
                    return BadRequest(new { success = false, message = "Unsuccessfull" });
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
