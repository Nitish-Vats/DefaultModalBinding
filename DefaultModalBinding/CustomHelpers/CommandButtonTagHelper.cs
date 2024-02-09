using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace DefaultModalBinding.CustomHelpers
{
    [HtmlTargetElement("command-button")]
    public class CommandButtonTagHelper:TagHelper
    {
        [HtmlAttributeName("value")] 
        public string Value{get;set;}
        [HtmlAttributeName("class")] 
        public string CssClass{get;set;}
        public override void Process(TagHelperContext context, TagHelperOutput output) 
        { 
            string strHtml = $"<button type='submit' name='command' class='{CssClass}'>{Value}</button>"; 
            output.Content.SetHtmlContent(strHtml); 
        }
    }
}
