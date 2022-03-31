#pragma checksum "C:\Users\emirs\source\repos\MarketManagement\WebApp\Pages\ProductComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22c9d0aa9a4d782a52ef602a6812a71f7569f0ea"
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
#line 1 "C:\Users\emirs\source\repos\MarketManagement\WebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\emirs\source\repos\MarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\emirs\source\repos\MarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\emirs\source\repos\MarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\emirs\source\repos\MarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\emirs\source\repos\MarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\emirs\source\repos\MarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\emirs\source\repos\MarketManagement\WebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\emirs\source\repos\MarketManagement\WebApp\_Imports.razor"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\emirs\source\repos\MarketManagement\WebApp\_Imports.razor"
using WebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\emirs\source\repos\MarketManagement\WebApp\_Imports.razor"
using Business;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Products")]
    public partial class ProductComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Products</h3>\r\n<br>");
#nullable restore
#line 8 "C:\Users\emirs\source\repos\MarketManagement\WebApp\Pages\ProductComponent.razor"
 if (products != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table");
            __builder.AddMarkupContent(3, "<thead><tr><th>Category</th>\r\n                <th>Name</th>\r\n                <th>Price</th>\r\n                <th>Quantity</th></tr></thead>\r\n        ");
            __builder.OpenElement(4, "tbody");
#nullable restore
#line 20 "C:\Users\emirs\source\repos\MarketManagement\WebApp\Pages\ProductComponent.razor"
             foreach (var product in products)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "tr");
            __builder.OpenElement(6, "td");
            __builder.AddContent(7, 
#nullable restore
#line 24 "C:\Users\emirs\source\repos\MarketManagement\WebApp\Pages\ProductComponent.razor"
                         GetCategoryById.Execute(product.CategoryId.Value)?.CategoryName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n                    ");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 27 "C:\Users\emirs\source\repos\MarketManagement\WebApp\Pages\ProductComponent.razor"
                         product.ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                    ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 30 "C:\Users\emirs\source\repos\MarketManagement\WebApp\Pages\ProductComponent.razor"
                          Math.Round(product.Price.Value, 2)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 33 "C:\Users\emirs\source\repos\MarketManagement\WebApp\Pages\ProductComponent.razor"
                         product.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 37 "C:\Users\emirs\source\repos\MarketManagement\WebApp\Pages\ProductComponent.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "C:\Users\emirs\source\repos\MarketManagement\WebApp\Pages\ProductComponent.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(17, "<br>\r\n");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "type", "button");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\emirs\source\repos\MarketManagement\WebApp\Pages\ProductComponent.razor"
                                OnClickAddProduct

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "class", "btn btn-primary");
            __builder.AddContent(22, "Add Product");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\emirs\source\repos\MarketManagement\WebApp\Pages\ProductComponent.razor"
       
    private List<Product> products;

    protected override void OnInitialized()
    {
        base.OnInitialized();
        LoadProduct();

    }
    private void OnClickAddProduct()
    {
        NavigationManager.NavigateTo("/AddProducts");
    }
    //private void EditCategory(Category category)
    //{
    //    NavigationManager.NavigateTo($"/EditCategory/{category.CategoryId}");
    //}
    //private void RemoveCategory(int categoryId)
    //{
    //    DeleteCategory.Delete(categoryId);
    //    LoadCategory();
    //}
    private void LoadProduct()
    {
        products = ViewProduct.Execute()?.ToList();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UseCase.IGetCategoryById GetCategoryById { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UseCase.IViewProducts ViewProduct { get; set; }
    }
}
#pragma warning restore 1591
