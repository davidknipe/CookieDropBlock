using System.Web.Mvc;
using EPiServer.Web.Mvc;

namespace CookieDropBlock.Controllers
{
    public class CookieDropBlockController : BlockController<Models.CookieDropBlock>
    {
        public override ActionResult Index(Models.CookieDropBlock currentContent)
        {
            return PartialView("~/modules/_protected/CookieDropBlock/Views/CookieDropBlock.cshtml", currentContent);
        }
    }
}
