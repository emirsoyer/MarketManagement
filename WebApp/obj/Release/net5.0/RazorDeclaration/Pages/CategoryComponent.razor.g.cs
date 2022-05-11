// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApp.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Categories")]
    public partial class CategoryComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\emirs\Source\Repos\MarketManagement\WebApp\Pages\CategoryComponent.razor"
       
    private List<Category> categories;

    protected override void OnInitialized()
    {
        base.OnInitialized();
        LoadCategory();

    }
    private void OnClickAddCategory()
    {
        NavigationManager.NavigateTo("/AddCategory");
    }
    private void EditCategory(Category category)
    {
        NavigationManager.NavigateTo($"/EditCategory/{category.CategoryId}");
    }
    private void RemoveCategory(int categoryId)
    {
        DeleteCategory.Delete(categoryId);
        LoadCategory();
    }
    private void LoadCategory()
    {
        categories = ViewCategory.Execute()?.ToList();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UseCase.IDeleteCategory DeleteCategory { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UseCase.IViewCategory ViewCategory { get; set; }
    }
}
#pragma warning restore 1591
