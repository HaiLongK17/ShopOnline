#pragma checksum "D:\.NET Core\ProjectPV\ShopOnline\ShopOnline\Areas\Admin\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b06ea9143ac4ab1c834bc869b607e294fbed3cdd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/Index.cshtml")]
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
#nullable restore
#line 1 "D:\.NET Core\ProjectPV\ShopOnline\ShopOnline\Areas\Admin\Views\_ViewImports.cshtml"
using ShopOnline;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.NET Core\ProjectPV\ShopOnline\ShopOnline\Areas\Admin\Views\_ViewImports.cshtml"
using ShopOnline.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b06ea9143ac4ab1c834bc869b607e294fbed3cdd", @"/Areas/Admin/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4682c439f88943ee5cecb3e049faf8833d2eeaf9", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CreateButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_TableButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\.NET Core\ProjectPV\ShopOnline\ShopOnline\Areas\Admin\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("Search", async() => {
                WriteLiteral(@"
    <div class=""input-group input-group-sm"">
        <input class=""form-control form-control-navbar"" type=""search"" placeholder=""Search"" aria-label=""Search"" />
        <div class=""input-group-append"">
            <button class=""btn btn-navbar"" type=""submit""><i class=""fas fa-search""></i></button>
        </div>
    </div>
");
            }
            );
            WriteLiteral(@"<div class=""content-header"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-sm-6"">
                <h1 class=""m-0 text-info"">Danh Sách Sản Phẩm</h1>
            </div>
            <div class=""col-sm-6"">
                <ol class=""breadcrumb float-sm-right"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b06ea9143ac4ab1c834bc869b607e294fbed3cdd4816", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </ol>\n            </div>\n        </div>\n    </div>\n</div>\n<section>\n    <div class=\"container-fluid\">\n        <div class=\"row\">\n            <div class=\"col-lg-12\">\n");
#nullable restore
#line 32 "D:\.NET Core\ProjectPV\ShopOnline\ShopOnline\Areas\Admin\Views\Product\Index.cshtml"
                 if (Model.Count() > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""main-card mb-3 card"">
                        <div class=""card-body p-0"">
                            <table class=""table table-bordered"">
                                <tr class=""table-secondary"">
                                    <th>
                                        ");
#nullable restore
#line 39 "D:\.NET Core\ProjectPV\ShopOnline\ShopOnline\Areas\Admin\Views\Product\Index.cshtml"
                                   Write(Html.DisplayNameFor(m => m.SortName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </th>
                                    <th>
                                        Loại
                                    </th>
                                    <th>
                                        Nhà Cung Cấp
                                    </th>
                                    <th>
                                        ");
#nullable restore
#line 48 "D:\.NET Core\ProjectPV\ShopOnline\ShopOnline\Areas\Admin\Views\Product\Index.cshtml"
                                   Write(Html.DisplayNameFor(m => m.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" (VND)\n                                    </th>\n                                    <th>\n                                        ");
#nullable restore
#line 51 "D:\.NET Core\ProjectPV\ShopOnline\ShopOnline\Areas\Admin\Views\Product\Index.cshtml"
                                   Write(Html.DisplayNameFor(m => m.UnitsInStock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </th>\n                                    <th>\n                                        ");
#nullable restore
#line 54 "D:\.NET Core\ProjectPV\ShopOnline\ShopOnline\Areas\Admin\Views\Product\Index.cshtml"
                                   Write(Html.DisplayNameFor(m => m.UnitsOnOder));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </th>\n                                    <th>\n                                        ");
#nullable restore
#line 57 "D:\.NET Core\ProjectPV\ShopOnline\ShopOnline\Areas\Admin\Views\Product\Index.cshtml"
                                   Write(Html.DisplayNameFor(m => m.Discontinued));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </th>\n                                    <th></th>\n                                </tr>\n");
#nullable restore
#line 61 "D:\.NET Core\ProjectPV\ShopOnline\ShopOnline\Areas\Admin\Views\Product\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\n                                        <td>\n                                            ");
#nullable restore
#line 65 "D:\.NET Core\ProjectPV\ShopOnline\ShopOnline\Areas\Admin\Views\Product\Index.cshtml"
                                       Write(Html.DisplayFor(m => item.SortName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        </td>\n                                        <td>\n                                            ");
#nullable restore
#line 68 "D:\.NET Core\ProjectPV\ShopOnline\ShopOnline\Areas\Admin\Views\Product\Index.cshtml"
                                       Write(Html.DisplayFor(m => item.Category.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        </td>\n                                        <td>\n                                            ");
#nullable restore
#line 71 "D:\.NET Core\ProjectPV\ShopOnline\ShopOnline\Areas\Admin\Views\Product\Index.cshtml"
                                       Write(Html.DisplayFor(m => item.Supplier.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        </td>\n                                        <td>\n                                            ");
#nullable restore
#line 74 "D:\.NET Core\ProjectPV\ShopOnline\ShopOnline\Areas\Admin\Views\Product\Index.cshtml"
                                       Write(Html.DisplayFor(m => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        </td>\n                                        <td>\n                                            ");
#nullable restore
#line 77 "D:\.NET Core\ProjectPV\ShopOnline\ShopOnline\Areas\Admin\Views\Product\Index.cshtml"
                                       Write(Html.DisplayFor(m => item.UnitsInStock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        </td>\n                                        <td>\n                                            ");
#nullable restore
#line 80 "D:\.NET Core\ProjectPV\ShopOnline\ShopOnline\Areas\Admin\Views\Product\Index.cshtml"
                                       Write(Html.DisplayFor(m => item.UnitsOnOder));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        </td>\n                                        <td>\n                                            ");
#nullable restore
#line 83 "D:\.NET Core\ProjectPV\ShopOnline\ShopOnline\Areas\Admin\Views\Product\Index.cshtml"
                                       Write(Html.DisplayFor(m => item.Discontinued));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        </td>\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b06ea9143ac4ab1c834bc869b607e294fbed3cdd12325", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 85 "D:\.NET Core\ProjectPV\ShopOnline\ShopOnline\Areas\Admin\Views\Product\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                    </tr>\n");
#nullable restore
#line 87 "D:\.NET Core\ProjectPV\ShopOnline\ShopOnline\Areas\Admin\Views\Product\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </table>\n                        </div>\n                    </div>\n");
#nullable restore
#line 91 "D:\.NET Core\ProjectPV\ShopOnline\ShopOnline\Areas\Admin\Views\Product\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>Chưa có sản phầm nào được tạo...</p>\n");
#nullable restore
#line 95 "D:\.NET Core\ProjectPV\ShopOnline\ShopOnline\Areas\Admin\Views\Product\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n        </div>\n    </div>\n</section>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
