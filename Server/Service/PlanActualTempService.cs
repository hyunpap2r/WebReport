using BlazorApp1.Server.Interface;
using BlazorApp1.Server.Models;
using BlazorApp1.Shared;

namespace BlazorApp1.Server.Service
{
    public class PlanActualTempService : IGPlanActualTemp
    {
        private readonly PlanActualContext _planActualTempContext;

        public PlanActualTempService(PlanActualContext planActualTempContext)
        {
            _planActualTempContext = planActualTempContext;
        }


        public List<PlanactualTemp> GetAllPlanActualTemp()
        {
            try
            {
                return _planActualTempContext.PlanactualTemps.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
