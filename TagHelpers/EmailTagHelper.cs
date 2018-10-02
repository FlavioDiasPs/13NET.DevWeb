using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula01.TagHelpers
{
    public class EmailTagHelper : TagHelper
    {
        public string MailToMommy { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            var address = $"{MailToMommy}@Manja.Rola";

            output.PreContent.SetContent("Eu sei que ");
            output.Attributes.SetAttribute("href", $"mailto:{address}");
            output.PostContent.SetContent(". É verdade esse teg.");
            output.Content.SetContent(address);
        }
    }


}
