#pragma checksum "D:\Projets\Blazor\FamilyHierarchy\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9230094bb15b0b0aea60feff52896f8e012b9923"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FamilyHierarchy.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\Projets\Blazor\FamilyHierarchy\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "D:\Projets\Blazor\FamilyHierarchy\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "D:\Projets\Blazor\FamilyHierarchy\_Imports.razor"
using Microsoft.AspNetCore.Components.Layouts;

#line default
#line hidden
#line 4 "D:\Projets\Blazor\FamilyHierarchy\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "D:\Projets\Blazor\FamilyHierarchy\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "D:\Projets\Blazor\FamilyHierarchy\_Imports.razor"
using FamilyHierarchy.Shared;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 12 "D:\Projets\Blazor\FamilyHierarchy\Pages\Index.razor"
 
    protected override async Task OnAfterRenderAsync()
    {
        var hierarchies = new Data.Hierarchies();
        var data = hierarchies.data;
        await JsRuntime.InvokeAsync<Task>("drawChart", data);
    }



#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
