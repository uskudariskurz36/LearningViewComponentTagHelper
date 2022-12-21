using LearningViewComponentTagHelper.Models;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text.Encodings.Web;

namespace LearningViewComponentTagHelper.TagHelpers
{
    [HtmlTargetElement("alert")]
    public class Alert : TagHelper
    {
        public Colors Color { get; set; }
        public string MessageText { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.AddClass("alert", HtmlEncoder.Default);
            output.AddClass($"alert-{Color}", HtmlEncoder.Default);

            output.Attributes.Add("title", "ben bir alertim");

            TagHelperContent content = output.GetChildContentAsync().Result;
            string childHtml = $"<h4>{MessageText}</h4>{content.GetContent()}";

            output.Content.SetHtmlContent(childHtml);
            
            //output.Content.SetContent("<b>aaa</b>");
            //output.Content.SetHtmlContent("<b>aaa</b>");

            //output.PreContent.SetContent("yyy-");
            //output.PostContent.SetContent("-xxx");
            //output.PreElement.SetHtmlContent("<i>sss</i>");
            //output.PostElement.SetHtmlContent("<i>ddd</i>");

            // <div class="alert alert-primary">aaa</div>
        }
    }
}
