using BlazorApp1.Server.Interface;
using BlazorApp1.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanActualTempController : ControllerBase
    {
        private readonly IGPlanActualTemp _IGplanactualTemp;


        public PlanActualTempController(IGPlanActualTemp gPlanActualTemp)
        {
            _IGplanactualTemp = gPlanActualTemp;
        }


        [HttpGet]
        public IEnumerable<PlanactualTemp> Get()
        {
            return _IGplanactualTemp.GetAllPlanActualTemp();

        }
    }
}
