using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Colonize.Website.TagHelpers
{
    public class HeroTagHelper : TagHelper
    {
        public string FirstName { get; set; }
        public string Message { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var example = "test";

            output.TagName = "<div>";
            output.Content.SetHtmlContent(example);
        }
    }
}
