#pragma checksum "/Users/work/Desktop/C#/EntityFiles/CRUD_Delicious/Views/Home/ViewOne.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4c6b52eb8db9a2af3ca120ee26a49641b646cbe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewOne), @"mvc.1.0.view", @"/Views/Home/ViewOne.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ViewOne.cshtml", typeof(AspNetCore.Views_Home_ViewOne))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/work/Desktop/C#/EntityFiles/CRUD_Delicious/Views/_ViewImports.cshtml"
using CrudDelicious;

#line default
#line hidden
#line 2 "/Users/work/Desktop/C#/EntityFiles/CRUD_Delicious/Views/_ViewImports.cshtml"
using CrudDelicious.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4c6b52eb8db9a2af3ca120ee26a49641b646cbe", @"/Views/Home/ViewOne.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e3476cfc9014dc11f49172991087a9128dd431e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewOne : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dish>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(12, 26, true);
            WriteLiteral("\n<a href=\"/\">Home</a>\n<h1>");
            EndContext();
            BeginContext(39, 14, false);
#line 4 "/Users/work/Desktop/C#/EntityFiles/CRUD_Delicious/Views/Home/ViewOne.cshtml"
Write(Model.DishName);

#line default
#line hidden
            EndContext();
            BeginContext(53, 10, true);
            WriteLiteral("</h1>\n<h4>");
            EndContext();
            BeginContext(64, 14, false);
#line 5 "/Users/work/Desktop/C#/EntityFiles/CRUD_Delicious/Views/Home/ViewOne.cshtml"
Write(Model.ChefName);

#line default
#line hidden
            EndContext();
            BeginContext(78, 17, true);
            WriteLiteral("</h4>\n<hr />\n\n<p>");
            EndContext();
            BeginContext(96, 18, false);
#line 8 "/Users/work/Desktop/C#/EntityFiles/CRUD_Delicious/Views/Home/ViewOne.cshtml"
Write(Model.Descriptions);

#line default
#line hidden
            EndContext();
            BeginContext(114, 18, true);
            WriteLiteral("</p>\n<p>Calories: ");
            EndContext();
            BeginContext(133, 14, false);
#line 9 "/Users/work/Desktop/C#/EntityFiles/CRUD_Delicious/Views/Home/ViewOne.cshtml"
        Write(Model.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(147, 19, true);
            WriteLiteral("</p>\n<p>Tastiness: ");
            EndContext();
            BeginContext(167, 15, false);
#line 10 "/Users/work/Desktop/C#/EntityFiles/CRUD_Delicious/Views/Home/ViewOne.cshtml"
         Write(Model.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(182, 8, true);
            WriteLiteral("</p>\n\n<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 190, "\"", 214, 2);
            WriteAttributeValue("", 197, "/delete/", 197, 8, true);
#line 12 "/Users/work/Desktop/C#/EntityFiles/CRUD_Delicious/Views/Home/ViewOne.cshtml"
WriteAttributeValue("", 205, Model.Id, 205, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(215, 31, true);
            WriteLiteral("><button>Delete</button></a>\n<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 246, "\"", 268, 2);
            WriteAttributeValue("", 253, "/edit/", 253, 6, true);
#line 13 "/Users/work/Desktop/C#/EntityFiles/CRUD_Delicious/Views/Home/ViewOne.cshtml"
WriteAttributeValue("", 259, Model.Id, 259, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(269, 27, true);
            WriteLiteral("><button>Edit</button></a>\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dish> Html { get; private set; }
    }
}
#pragma warning restore 1591
