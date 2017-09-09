using Don.ApbDefault.Controllers;
using Microsoft.AspNetCore.Antiforgery;

namespace Don.ApbDefault.Web.Host.Controllers
{
    public class AntiForgeryController : ApbDefaultControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}