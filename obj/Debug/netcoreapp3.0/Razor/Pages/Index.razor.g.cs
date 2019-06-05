#pragma checksum "C:\Users\rdesalbres.DIRMESSAGES\Documents\Projets\Blazor\FamilyHierarchy\FamilyHierarchy\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7d4ed9037f447ce999420ed35eb3a2c6d7e23d3"
// <auto-generated/>
#pragma warning disable 1591
namespace FamilyHierarchy.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Components.Forms;
    using Microsoft.AspNetCore.Components.Layouts;
    using Microsoft.AspNetCore.Components.Routing;
    using Microsoft.JSInterop;
    using FamilyHierarchy.Shared;
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n\r\n");
            builder.AddMarkupContent(1, "<div id=\"chart\">\r\n\r\n</div>");
        }
        #pragma warning restore 1998
#line 12 "C:\Users\rdesalbres.DIRMESSAGES\Documents\Projets\Blazor\FamilyHierarchy\FamilyHierarchy\Pages\Index.razor"
 
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
