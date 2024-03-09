using BlazorApp1.Server.Interface;
using BlazorApp1.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvPickRequestController : ControllerBase
    {
        private readonly IGInvPickRequest _InvPickRequest;

        public InvPickRequestController(IGInvPickRequest gInvPickRequest)
        {
            _InvPickRequest =   gInvPickRequest;
        }


        [HttpGet]
        [Route("{SelectAll}")]
        public IEnumerable<InvPickRequest> Get()
        {
            return _InvPickRequest.GetAllPickRequest();

        }

    }




}
