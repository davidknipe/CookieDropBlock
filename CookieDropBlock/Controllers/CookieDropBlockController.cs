using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace CookieDropBlock.Controllers
{
    public class CookieDropBlockController : BlockComponent<Models.CookieDropBlock>
    {
        public override IViewComponentResult Invoke(Models.CookieDropBlock currentContent)
        {
            return View("/Views/CookieDropBlock/Index.cshtml", currentContent);
        }
    }
}
