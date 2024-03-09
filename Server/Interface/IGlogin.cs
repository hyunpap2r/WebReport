using BlazorApp1.Shared;

namespace BlazorApp1.Server.Interface
{
    public interface IGlogin
    {
        public List<EappUser> GetAllEappUsers();

    }
}
