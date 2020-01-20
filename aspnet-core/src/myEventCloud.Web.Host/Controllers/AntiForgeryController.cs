using Microsoft.AspNetCore.Antiforgery;
using myEventCloud.Controllers;

namespace myEventCloud.Web.Host.Controllers
{
    public class AntiForgeryController : myEventCloudControllerBase
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
