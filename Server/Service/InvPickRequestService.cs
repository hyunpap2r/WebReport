using BlazorApp1.Server.Interface;
using BlazorApp1.Server.Models;
using BlazorApp1.Shared;

namespace BlazorApp1.Server.Service
{
    public class InvPickRequestService : IGInvPickRequest
    {
        private readonly PlanActualContext _InvPickRequest;

        public InvPickRequestService(PlanActualContext InvPickRequestcontext)
        {
            _InvPickRequest = InvPickRequestcontext;
        }


        public List<InvPickRequest> GetAllPickRequest()
        {
            try
            {
                return _InvPickRequest.InvPickRequests.ToList();

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
