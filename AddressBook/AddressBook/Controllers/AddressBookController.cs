using BusinessLayer.Interface;
using CommonLayer.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressBookController : ControllerBase
    {
        public IAddressBookBL addressBL;
        private readonly IMemoryCache memoryCache;
        private readonly IDistributedCache distributedCache;
        private readonly ILogger<AddressBookController> _logger;
        public AddressBookController(IAddressBookBL addressBL, IMemoryCache memoryCache, IDistributedCache distributedCache, ILogger<AddressBookController> _logger)
        {
            this.addressBL = addressBL;
            this.memoryCache = memoryCache;
            this.distributedCache = distributedCache;
            this._logger = _logger;
        }
        [HttpPost("create")]
        public IActionResult Create(AddressBookModel model)
        {
            try
            {
                var result = addressBL.Create(model);
                if (result != null)
                {
                    _logger.LogInformation(" AddressBook Created");
                    return Ok(new { success = true, message = "AddressBook Created", data = result });
                }
                else
                {
                    _logger.LogInformation("AddressBook is Invalid");
                    return BadRequest(new { success = false, message = "AddressBook is Invalid" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw ex;
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
                    _logger.LogInformation("Addressbook retrived successfully");
                    return Ok(new { success = true, message = "Addressbook retrived successfully", data = result });
                }
                else
                {
                    _logger.LogInformation("Unsuccessfull");
                    return BadRequest(new { success = false, message = "Unsuccessfull" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw ex;
            }
        }

        [HttpPut("Update")]
        public IActionResult UpdateAddressBook(long Id, AddressBookModel model)
        {
            try
            {
                //long UserId = Convert.ToInt32(User.Claims.FirstOrDefault(e => e.Type == "Id").Value);
                var result = addressBL.UpdateAddressBook(Id, model);
                if (result != null)
                {
                    _logger.LogInformation("Address Book Updated Successfully");
                    return Ok(new { success = true, message = "Address Book Updated Successfully", data = result });
                }
                else
                {
                    _logger.LogInformation("Unsuccessfull");
                    return BadRequest(new { success = false, message = "Unsuccessfull" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw ex;
            }


        }
        [HttpDelete("Delete")]
        public IActionResult DeleteAddressBook(long Id)
        {
            try
            {
                var result = addressBL.DeleteAddressBook(Id);
                if (result != null)
                {
                    _logger.LogInformation("Address Book Deleted Successfull");
                    return Ok(new { success = true, message = "Address Book Deleted Successfully" });
                }
                else
                {
                    _logger.LogInformation("Unsuccessfull");
                    return BadRequest(new { success = false, message = "Unsuccessfull" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw ex;
            }
            //[Authorize]
            //[HttpGet("Redis")]
            //public async Task<IActionResult> GetAllAddressBookUsingRedisCache()
            //{
            //    var cacheKey = "AddressBookList";
            //    string serializedNoteList;
            //    var AddressBookList = new List<Entity>();
            //    var redisNotesList = await distributedCache.GetAsync(cacheKey);
            //    if (redisNotesList != null)
            //    {

            //        serializedNoteList = Encoding.UTF8.GetString(redisNotesList);
            //        redisNotesList = JsonConvert.DeserializeObject<List<NoteEntity>>(serializedNoteList);
            //    }
            //    else
            //    {
            //        redisNotesList = await .NoteTable.ToListAsync();
            //        serializedNoteList = JsonConvert.SerializeObject(redisNotesList);
            //        redisNotesList = Encoding.UTF8.GetBytes(serializedNoteList);
            //        var options = new DistributedCacheEntryOptions()
            //            .SetAbsoluteExpiration(DateTime.Now.AddMinutes(10))
            //            .SetSlidingExpiration(TimeSpan.FromMinutes(2));
            //        await distributedCache.SetAsync(cacheKey, redisNotesList, options);
            //    }
            //    return Ok(redisNotesList);
            //}

        }
    }
}
