using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SportsStore.Models;


namespace SportsStore.Infrastructure
{
    [HtmlTargetElement("div", Attributes = "page-model")]

    public class PageLinkTagHelper : TagHelper
    {
        //FIELDS & PROPERTIES
        private IUrlHelperFactory _urlHelperFactory;
        public string PageAction { get; set; }
        public PagingInfo PageModel { get; set; }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }


        //CONSTRUCTORS
        public PageLinkTagHelper
           (IUrlHelperFactory helperFactory)
        {
            _urlHelperFactory = helperFactory;
        }


        //METHODS
        public override void Process (TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper urlHelper = _urlHelperFactory.GetUrlHelper(ViewContext);
            TagBuilder result = new TagBuilder("div");
            
            for (int i = 1; i <= PageModel.TotalPages; i++)
            {
                if (i != PageModel.CurrentPage)
                {
                    TagBuilder anchorTag = new TagBuilder("a");
                    anchorTag.Attributes["href"] = urlHelper.Action(PageAction, new { productPage = i });
                    anchorTag.InnerHtml.Append($"Page {i}");
                    result.InnerHtml.AppendHtml(anchorTag);
                    result.InnerHtml.AppendHtml("&nbsp; &nbsp;");
                }
                else
                {
                    result.InnerHtml.AppendHtml($"Page {i} &nbsp; &nbsp;");
                }
            }
            output.Content.AppendHtml(result.InnerHtml);
        }

    }
}
