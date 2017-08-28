using SomethingToDo.Context;
using SomethingToDo.DTO.User;
using SomethingToDo.Models;
using SomethingToDo.Services.User;
using SomethingToDo.Utility;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace SomethingToDo.Controllers
{
    [RoutePrefix("api/user")]
    public class UserController : ApiController
    {
        private readonly IUserService service;

        public UserController(IUserService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("{email}/")]
        [ResponseType(typeof(User))]
        public async Task<IHttpActionResult> GetUserByEmail([FromUri]string email)
        {
            var result = await service.GetAsync(email);

            return Ok(result);
        }

        [HttpPost]
        [Route("save")]
        public async Task<IHttpActionResult> Save([FromBody]UserDTO dto)
        {
            var user = EntityMapper.Map(dto);
                
            await service.CreateAsync(user);

            return Ok();
        }
    }
}
