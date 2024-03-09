using BlazorApp1.Server.Interface;
using BlazorApp1.Server.Models;
using BlazorApp1.Shared;

namespace BlazorApp1.Server.Service
{
    public class LoginService : IGlogin
    {
        private readonly PlanActualContext _Logincontext;

        public LoginService(PlanActualContext LoginTempContext)
        {
            _Logincontext = LoginTempContext;
        }


        public List<EappUser> GetAllEappUsers()
        {
            try
            {
                return _Logincontext.EappUsers.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
