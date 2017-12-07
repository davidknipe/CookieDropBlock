using EPiServer.Configuration;
using EPiServer.DataAnnotations;

namespace CookieDropBlock.Attributes
{
    public class IconAttribute : ImageUrlAttribute
    {
        public IconAttribute() : base("~/ignored") { }

        public override string Path
        {
            get
            {
                var uiUrl = Settings.Instance.UIUrl.OriginalString.TrimStart("~/".ToCharArray()).TrimEnd("/".ToCharArray()).TrimEnd("CMS".ToCharArray());
                return "~/" + uiUrl + "/CookieDropBlock/Images/block-type-thumbnail-cookiedrop.png";
            }
        }
    }
}