#pragma checksum "/Users/work/Desktop/C#/EntityFiles/CRUD_Delicious/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7b646e62134d98c42c3f743d288660301388321"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "/Users/work/Desktop/C#/EntityFiles/CRUD_Delicious/Views/Home/Index.cshtml"
using CrudDelicious.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7b646e62134d98c42c3f743d288660301388321", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e3476cfc9014dc11f49172991087a9128dd431e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dish>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 145, true);
            WriteLiteral("\r\n<h1>Welcome to CRUDelicious</h1>\r\n\r\n<p>Check out some recent dishes!</p>\r\n\r\n<a class=\'btn btn-secondary\' href=\"/AddNew\">Add a Dish!</a>\r\n\r\n\r\n\r\n");
            EndContext();
#line 12 "/Users/work/Desktop/C#/EntityFiles/CRUD_Delicious/Views/Home/Index.cshtml"
  
    foreach(var user in Model){

#line default
#line hidden
            BeginContext(231, 13, true);
            WriteLiteral("        <p><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 244, "\"", 265, 2);
            WriteAttributeValue("", 251, "/view/", 251, 6, true);
#line 14 "/Users/work/Desktop/C#/EntityFiles/CRUD_Delicious/Views/Home/Index.cshtml"
WriteAttributeValue("", 257, user.Id, 257, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(266, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(268, 13, false);
#line 14 "/Users/work/Desktop/C#/EntityFiles/CRUD_Delicious/Views/Home/Index.cshtml"
                               Write(user.ChefName);

#line default
#line hidden
            EndContext();
            BeginContext(281, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(283, 13, false);
#line 14 "/Users/work/Desktop/C#/EntityFiles/CRUD_Delicious/Views/Home/Index.cshtml"
                                              Write(user.DishName);

#line default
#line hidden
            EndContext();
            BeginContext(296, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(298, 13, false);
#line 14 "/Users/work/Desktop/C#/EntityFiles/CRUD_Delicious/Views/Home/Index.cshtml"
                                                             Write(user.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(311, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(313, 14, false);
#line 14 "/Users/work/Desktop/C#/EntityFiles/CRUD_Delicious/Views/Home/Index.cshtml"
                                                                            Write(user.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(327, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(329, 17, false);
#line 14 "/Users/work/Desktop/C#/EntityFiles/CRUD_Delicious/Views/Home/Index.cshtml"
                                                                                            Write(user.Descriptions);

#line default
#line hidden
            EndContext();
            BeginContext(346, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 15 "/Users/work/Desktop/C#/EntityFiles/CRUD_Delicious/Views/Home/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(362, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dish>> Html { get; private set; }
    }
}
#pragma warning restore 1591