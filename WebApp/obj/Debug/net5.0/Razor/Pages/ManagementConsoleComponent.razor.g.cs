#pragma checksum "C:\Users\PC\source\repos\MarketManagement\WebApp\Pages\ManagementConsoleComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dcb17d057b37c33b22e16dd8119078f9234fece6"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\PC\source\repos\MarketManagement\WebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PC\source\repos\MarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\PC\source\repos\MarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PC\source\repos\MarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\PC\source\repos\MarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\PC\source\repos\MarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\PC\source\repos\MarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\PC\source\repos\MarketManagement\WebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\PC\source\repos\MarketManagement\WebApp\_Imports.razor"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\PC\source\repos\MarketManagement\WebApp\_Imports.razor"
using WebApp.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\PC\source\repos\MarketManagement\WebApp\_Imports.razor"
using WebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\PC\source\repos\MarketManagement\WebApp\_Imports.razor"
using Business;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/managementconsole")]
    public partial class ManagementConsoleComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Management Console</h3>\r\n<br>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-3");
            __builder.OpenComponent<WebApp.Controls.SelectProductSellingComponent>(5);
            __builder.AddAttribute(6, "OnProductCallback", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Business.Product>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Business.Product>(this, 
#nullable restore
#line 6 "C:\Users\PC\source\repos\MarketManagement\WebApp\Pages\ManagementConsoleComponent.razor"
                                                          SelectProduct

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n        <br>\r\n        ");
            __builder.OpenComponent<WebApp.Controls.SellProductComponent>(8);
            __builder.AddAttribute(9, "SelectedProduct", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Business.Product>(
#nullable restore
#line 8 "C:\Users\PC\source\repos\MarketManagement\WebApp\Pages\ManagementConsoleComponent.razor"
                                               selectedProduct

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "OnProductSold", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Business.Product>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Business.Product>(this, 
#nullable restore
#line 8 "C:\Users\PC\source\repos\MarketManagement\WebApp\Pages\ManagementConsoleComponent.razor"
                                                                               SellProduct

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.AddMarkupContent(12, "<div class=\"col\">Place Holder\r\n    </div>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\PC\source\repos\MarketManagement\WebApp\Pages\ManagementConsoleComponent.razor"
       

    private Product selectedProduct;
    private void SelectProduct(Product product)
    {
        selectedProduct = product;
    }

    private void SellProduct(Product product)
    {

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591