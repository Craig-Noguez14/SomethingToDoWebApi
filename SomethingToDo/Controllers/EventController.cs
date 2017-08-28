using SomethingToDo.DTO.Event;
using SomethingToDo.Services.Event;
using SomethingToDo.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace SomethingToDo.Controllers
{
    [RoutePrefix("api/event")]
    public class EventController : ApiController
    {
        private readonly IEventService service;

        public EventController(IEventService service)
        {
            this.service = service;
        }

        [Route("PostEvent")]
        [HttpPost]
        public async Task<IHttpActionResult> PostEventAsync([FromBody]EventDTO dto)
        {
            var evnt = EntityMapper.Map(dto);

            await service.CreateAsync(evnt);

            return Ok();
        }
    }
}