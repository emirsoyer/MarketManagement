#pragma checksum "C:\Users\emirs\source\repos\MarketManagement\WebApp\Pages\EditProductComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f68cd307cac1f41a9e19429a3e05231bc5da22e"
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
using WebApp.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\emirs\source\repos\MarketManagement\WebApp\_Imports.razor"
using WebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\emirs\source\repos\MarketManagement\WebApp\_Imports.razor"
using Business;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditProduct/{productId}")]
    public partial class EditProductComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Update Product Information</h3>");
#nullable restore
#line 11 "C:\Users\emirs\source\repos\MarketManagement\WebApp\Pages\EditProductComponent.razor"
 if (product != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "C:\Users\emirs\source\repos\MarketManagement\WebApp\Pages\EditProductComponent.razor"
                 product

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "C:\Users\emirs\source\repos\MarketManagement\WebApp\Pages\EditProductComponent.razor"
                                         OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "form-group");
                __builder2.AddMarkupContent(11, "<label for=\"category\">\r\n            Category\r\n        </label>\r\n        ");
                __builder2.OpenElement(12, "select");
                __builder2.AddAttribute(13, "id", "category");
                __builder2.AddAttribute(14, "class", "form-control");
                __builder2.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\emirs\source\repos\MarketManagement\WebApp\Pages\EditProductComponent.razor"
                                     product.CategoryId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => product.CategoryId = __value, product.CategoryId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.OpenElement(17, "option");
                __builder2.AddAttribute(18, "selected");
                __builder2.CloseElement();
#nullable restore
#line 22 "C:\Users\emirs\source\repos\MarketManagement\WebApp\Pages\EditProductComponent.razor"
             foreach (var cat in categories)
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(19, "option");
                __builder2.AddAttribute(20, "value", 
#nullable restore
#line 24 "C:\Users\emirs\source\repos\MarketManagement\WebApp\Pages\EditProductComponent.razor"
                                cat.CategoryId

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 24 "C:\Users\emirs\source\repos\MarketManagement\WebApp\Pages\EditProductComponent.razor"
__builder2.AddContent(21, cat.CategoryName);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 25 "C:\Users\emirs\source\repos\MarketManagement\WebApp\Pages\EditProductComponent.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n    ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-group");
                __builder2.AddMarkupContent(25, "<label for=\"name\">\r\n            Name\r\n        </label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(26);
                __builder2.AddAttribute(27, "id", "name");
                __builder2.AddAttribute(28, "class", "form-control");
                __builder2.AddAttribute(29, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "C:\Users\emirs\source\repos\MarketManagement\WebApp\Pages\EditProductComponent.razor"
                                          product.ProductName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.ProductName = __value, product.ProductName))));
                __builder2.AddAttribute(31, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => product.ProductName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n    ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "form-group");
                __builder2.AddMarkupContent(35, "<label for=\"price\">\r\n            Price\r\n        </label>\r\n        ");
                __Blazor.WebApp.Pages.EditProductComponent.TypeInference.CreateInputNumber_0(__builder2, 36, 37, "price", 38, "form-control", 39, 
#nullable restore
#line 38 "C:\Users\emirs\source\repos\MarketManagement\WebApp\Pages\EditProductComponent.razor"
                                             product.Price

#line default
#line hidden
#nullable disable
                , 40, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.Price = __value, product.Price)), 41, () => product.Price);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n    ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "form-group");
                __builder2.AddMarkupContent(45, "<label for=\"quantity\">\r\n            Quantity\r\n        </label>\r\n        ");
                __Blazor.WebApp.Pages.EditProductComponent.TypeInference.CreateInputNumber_1(__builder2, 46, 47, "quantity", 48, "form-control", 49, 
#nullable restore
#line 44 "C:\Users\emirs\source\repos\MarketManagement\WebApp\Pages\EditProductComponent.razor"
                                                product.Quantity

#line default
#line hidden
#nullable disable
                , 50, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.Quantity = __value, product.Quantity)), 51, () => product.Quantity);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n\r\n    ");
                __builder2.AddMarkupContent(53, "<button type=\"submit\" class=\"btn btn-primary\">Update</button>\r\n    ");
                __builder2.OpenElement(54, "button");
                __builder2.AddAttribute(55, "type", "button");
                __builder2.AddAttribute(56, "class", "btn btn-primary");
                __builder2.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\emirs\source\repos\MarketManagement\WebApp\Pages\EditProductComponent.razor"
                                                            OnCancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(58, "Cancel");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 51 "C:\Users\emirs\source\repos\MarketManagement\WebApp\Pages\EditProductComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\emirs\source\repos\MarketManagement\WebApp\Pages\EditProductComponent.razor"
       
    [Parameter]
    public string ProductId { get; set; }

    private Product product;
    private IEnumerable<Category> categories;

    protected override void OnInitialized()
    {
        base.OnInitialized();
        categories = ViewCategory.Execute();
    }

    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        if (int.TryParse(this.ProductId, out int iProductId))
        {
            var clnProd = GetProductById.Execute(iProductId);
            this.product = new Product { ProductId = clnProd.ProductId, CategoryId = clnProd.CategoryId, ProductName = clnProd.ProductName, Price = clnProd.Price, Quantity = clnProd.Quantity };
        }
    }
    private void OnValidSubmit()
    {
        EditProduct.Execute(this.product);
        NavigationManager.NavigateTo("/Products");
    }
    private void OnCancel()
    {
        NavigationManager.NavigateTo("/Products");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UseCase.IViewCategory ViewCategory { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UseCase.IEditProduct EditProduct { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UseCase.IAddProduct AddProduct { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UseCase.IGetProductById GetProductById { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
namespace __Blazor.WebApp.Pages.EditProductComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
