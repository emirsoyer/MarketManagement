#pragma checksum "C:\Users\PC\source\repos\MarketManagement\WebApp\Controls\SelectProductSellingComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0dd9181f04a4118dad811803efbec73df4d8f8ba"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApp.Controls
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
    public partial class SelectProductSellingComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3></h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "form-group");
            __builder.AddMarkupContent(3, "<label for=\"category\">\r\n        Category\r\n    </label>\r\n    ");
            __builder.OpenElement(4, "select");
            __builder.AddAttribute(5, "id", "category");
            __builder.AddAttribute(6, "class", "form-control");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\PC\source\repos\MarketManagement\WebApp\Controls\SelectProductSellingComponent.razor"
                                 SelectedCategoryId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SelectedCategoryId = __value, SelectedCategoryId));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(9, "option");
            __builder.AddAttribute(10, "selected");
            __builder.CloseElement();
#nullable restore
#line 13 "C:\Users\PC\source\repos\MarketManagement\WebApp\Controls\SelectProductSellingComponent.razor"
         foreach (var cat in categories)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "option");
            __builder.AddAttribute(12, "value", 
#nullable restore
#line 15 "C:\Users\PC\source\repos\MarketManagement\WebApp\Controls\SelectProductSellingComponent.razor"
                            cat.CategoryId

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 15 "C:\Users\PC\source\repos\MarketManagement\WebApp\Controls\SelectProductSellingComponent.razor"
__builder.AddContent(13, cat.CategoryName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 16 "C:\Users\PC\source\repos\MarketManagement\WebApp\Controls\SelectProductSellingComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 19 "C:\Users\PC\source\repos\MarketManagement\WebApp\Controls\SelectProductSellingComponent.razor"
 if (productsInCategory != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "table");
            __builder.AddAttribute(15, "class", "table");
            __builder.AddMarkupContent(16, "<thead><tr><th>Product Name</th>\r\n            <th>Quantity</th></tr></thead>\r\n        ");
            __builder.OpenElement(17, "tbody");
#nullable restore
#line 29 "C:\Users\PC\source\repos\MarketManagement\WebApp\Controls\SelectProductSellingComponent.razor"
         foreach (var prod in productsInCategory)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "tr");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\PC\source\repos\MarketManagement\WebApp\Controls\SelectProductSellingComponent.razor"
                            ()=> OnSelectProduct(prod)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "style", 
#nullable restore
#line 32 "C:\Users\PC\source\repos\MarketManagement\WebApp\Controls\SelectProductSellingComponent.razor"
                         prod.ProductId == selectedProductId?"background-color:aquamarine;cursor:pointer;":"cursor:pointer"

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(21, "td");
#nullable restore
#line 34 "C:\Users\PC\source\repos\MarketManagement\WebApp\Controls\SelectProductSellingComponent.razor"
__builder.AddContent(22, prod.ProductName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "td");
#nullable restore
#line 37 "C:\Users\PC\source\repos\MarketManagement\WebApp\Controls\SelectProductSellingComponent.razor"
__builder.AddContent(25, prod.Quantity);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "C:\Users\PC\source\repos\MarketManagement\WebApp\Controls\SelectProductSellingComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 43 "C:\Users\PC\source\repos\MarketManagement\WebApp\Controls\SelectProductSellingComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\PC\source\repos\MarketManagement\WebApp\Controls\SelectProductSellingComponent.razor"
       
    [Parameter]
    public EventCallback<Product> OnProductCallback { get; set; }

    private IEnumerable<Product> productsInCategory;

    private int selectedCategoryId;
    private int selectedProductId;

    public int SelectedCategoryId
    {
        get { return selectedCategoryId; }
        set
        {
            selectedCategoryId = value;
            productsInCategory = ViewProductsByCategoryId.Execute(value);
            OnSelectProduct(null);
            StateHasChanged();
        }
    }

    private IEnumerable<Category> categories;

    protected override void OnInitialized()
    {
        base.OnInitialized();
        categories = ViewCategory.Execute();
    }

    private void OnSelectProduct(Product product)
    {
        OnProductCallback.InvokeAsync(product);
        if (product != null)
        {
            selectedProductId = product.ProductId;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UseCase.IViewProductByCategoryId ViewProductsByCategoryId { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UseCase.IViewCategory ViewCategory { get; set; }
    }
}
#pragma warning restore 1591
