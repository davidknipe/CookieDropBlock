using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CookieDropBlock.Controllers
{
    [Route("cookiedropblock/[controller]")]
    public class BlockIconController : Controller
    {
        [HttpGet, Produces("image/png")]
        public async Task<IActionResult> Get()
        {
            var assembly = GetType().Assembly;
            var resourceStream = assembly.GetManifestResourceStream("CookieDropBlock.images.blocktypethumbnail.png");
            return File(resourceStream, "image/png");
        }
    }
}