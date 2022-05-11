// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApp.Controls
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\emirs\Source\Repos\MarketManagement\WebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\emirs\Source\Repos\MarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\emirs\Source\Repos\MarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\emirs\Source\Repos\MarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\emirs\Source\Repos\MarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\emirs\Source\Repos\MarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\emirs\Source\Repos\MarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\emirs\Source\Repos\MarketManagement\WebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\emirs\Source\Repos\MarketManagement\WebApp\_Imports.razor"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\emirs\Source\Repos\MarketManagement\WebApp\_Imports.razor"
using WebApp.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\emirs\Source\Repos\MarketManagement\WebApp\_Imports.razor"
using WebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\emirs\Source\Repos\MarketManagement\WebApp\_Imports.razor"
using Business;

#line default
#line hidden
#nullable disable
    public partial class SellProductComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\emirs\Source\Repos\MarketManagement\WebApp\Controls\SellProductComponent.razor"
       
    private Product productSell;
    private string errorMessage;

    [Parameter]
    public string SellerName { get; set; }

    [Parameter]
    public Product SelectedProduct { get; set; }

    [Parameter]
    public EventCallback<Product> OnProductSold { get; set; }

    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        if (SelectedProduct != null)
        {
            productSell = new Product
            {
                ProductId = SelectedProduct.ProductId,
                ProductName = SelectedProduct.ProductName,
                CategoryId = SelectedProduct.CategoryId,
                Price = SelectedProduct.Price,
                Quantity = 0
            };
        }
        else
        {
            productSell = null;
        }
    }

    private void SellProduct()
    {
        if (string.IsNullOrWhiteSpace(SellerName))
        {
            errorMessage = "Seller needs to be identified, otherwise cannot sell product";
            return;
        }
        var product = GetProductById.Execute(productSell.ProductId);
        if (productSell.Quantity <= 0)
        {
            errorMessage = "Cannot sell 0 products";
        }
        else if (product.Quantity >= productSell.Quantity)
        {
            OnProductSold.InvokeAsync(productSell);
            errorMessage = string.Empty;
            SellProductCase.Execute(SellerName ,productSell.ProductId, productSell.Quantity.Value);
        }
        else
        {
            errorMessage = $"Amount of {product.ProductName} left = {product.Quantity}. Not enough to sell";
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UseCase.ISellProduct SellProductCase { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UseCase.IGetProductById GetProductById { get; set; }
    }
}
#pragma warning restore 1591