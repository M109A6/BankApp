#pragma checksum "C:\Users\ADGONZ\source\git\BankApp\BankUI\Views\Accounts\Transactions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40250e7396c44288868f04b5e1aead8c326d7a91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_Transactions), @"mvc.1.0.view", @"/Views/Accounts/Transactions.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Accounts/Transactions.cshtml", typeof(AspNetCore.Views_Accounts_Transactions))]
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
#line 1 "C:\Users\ADGONZ\source\git\BankApp\BankUI\Views\_ViewImports.cshtml"
using BankUI;

#line default
#line hidden
#line 2 "C:\Users\ADGONZ\source\git\BankApp\BankUI\Views\_ViewImports.cshtml"
using BankUI.Models;

#line default
#line hidden
#line 4 "C:\Users\ADGONZ\source\git\BankApp\BankUI\Views\_ViewImports.cshtml"
using BankApp;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40250e7396c44288868f04b5e1aead8c326d7a91", @"/Views/Accounts/Transactions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce68914e8061298532548356daad8e7f142c9333", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts_Transactions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BankApp.Transaction>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ADGONZ\source\git\BankApp\BankUI\Views\Accounts\Transactions.cshtml"
  
    ViewData["Title"] = "Transactions";

#line default
#line hidden
            BeginContext(91, 113, true);
            WriteLiteral("\r\n<h2>Transactions</h2>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(205, 51, false);
#line 14 "C:\Users\ADGONZ\source\git\BankApp\BankUI\Views\Accounts\Transactions.cshtml"
           Write(Html.DisplayNameFor(model => model.TransactionDate));

#line default
#line hidden
            EndContext();
            BeginContext(256, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(312, 46, false);
#line 17 "C:\Users\ADGONZ\source\git\BankApp\BankUI\Views\Accounts\Transactions.cshtml"
           Write(Html.DisplayNameFor(model => model.Descrition));

#line default
#line hidden
            EndContext();
            BeginContext(358, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(414, 53, false);
#line 20 "C:\Users\ADGONZ\source\git\BankApp\BankUI\Views\Accounts\Transactions.cshtml"
           Write(Html.DisplayNameFor(model => model.TypeOfTransaction));

#line default
#line hidden
            EndContext();
            BeginContext(467, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(523, 42, false);
#line 23 "C:\Users\ADGONZ\source\git\BankApp\BankUI\Views\Accounts\Transactions.cshtml"
           Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(565, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(621, 43, false);
#line 26 "C:\Users\ADGONZ\source\git\BankApp\BankUI\Views\Accounts\Transactions.cshtml"
           Write(Html.DisplayNameFor(model => model.Account));

#line default
#line hidden
            EndContext();
            BeginContext(664, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 32 "C:\Users\ADGONZ\source\git\BankApp\BankUI\Views\Accounts\Transactions.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(782, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(831, 50, false);
#line 35 "C:\Users\ADGONZ\source\git\BankApp\BankUI\Views\Accounts\Transactions.cshtml"
           Write(Html.DisplayFor(modelItem => item.TransactionDate));

#line default
#line hidden
            EndContext();
            BeginContext(881, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(937, 45, false);
#line 38 "C:\Users\ADGONZ\source\git\BankApp\BankUI\Views\Accounts\Transactions.cshtml"
           Write(Html.DisplayFor(modelItem => item.Descrition));

#line default
#line hidden
            EndContext();
            BeginContext(982, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1038, 52, false);
#line 41 "C:\Users\ADGONZ\source\git\BankApp\BankUI\Views\Accounts\Transactions.cshtml"
           Write(Html.DisplayFor(modelItem => item.TypeOfTransaction));

#line default
#line hidden
            EndContext();
            BeginContext(1090, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1146, 41, false);
#line 44 "C:\Users\ADGONZ\source\git\BankApp\BankUI\Views\Accounts\Transactions.cshtml"
           Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(1187, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1243, 55, false);
#line 47 "C:\Users\ADGONZ\source\git\BankApp\BankUI\Views\Accounts\Transactions.cshtml"
           Write(Html.DisplayFor(modelItem => item.Account.EmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(1298, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 50 "C:\Users\ADGONZ\source\git\BankApp\BankUI\Views\Accounts\Transactions.cshtml"
}

#line default
#line hidden
            BeginContext(1337, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BankApp.Transaction>> Html { get; private set; }
    }
}
#pragma warning restore 1591
