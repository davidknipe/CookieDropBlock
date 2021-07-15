using EPiServer.DataAnnotations;

namespace CookieDropBlock.Attributes
{
    public class IconAttribute : ImageUrlAttribute
    {
        public IconAttribute() : base("~/ignored") { }

        public override string Path => "/cookiedropblock/blockicon";
    }
}
