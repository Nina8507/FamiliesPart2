// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FamiliesPart2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\_Imports.razor"
using FamiliesPart2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\_Imports.razor"
using FamiliesPart2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\Pages\Adults.razor"
using FamiliesPart2.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\Pages\Adults.razor"
using FamiliesPart2.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Adults")]
    public partial class Adults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 75 "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\Pages\Adults.razor"
       
    private IList<Adult> _adultsToShow = new List<Adult>();
    private IList<Adult> _adults = new List<Adult>();
    private string _filterByName;
    
    protected override async Task OnInitializedAsync()
    {
        _adultsToShow = await _adultService.GetAllAsync();
        //_adultsToShow = _adults;
    }

    private void Filter(ChangeEventArgs changeEventArgs)
    {
        _filterByName = null;
        try
        {
            _filterByName = changeEventArgs.Value.ToString();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.StackTrace);
            throw;
        }
        ExecuteFilter();
    }

    private void ExecuteFilter()
    {
        _adultsToShow = _adults.Where(a => a.FirstName.Equals(_filterByName)).ToList();
    }

    private async Task RemoveAdultAsync(int adultId)
    {
        await _adultService.RemoveAsync(adultId);
        Adult adultToRemove = _adults.FirstOrDefault(a => a.Id == adultId);
        _adultsToShow.Remove(adultToRemove);
        _adults.Remove(adultToRemove);
    }

    private async Task EditAdultAsync(int adultId)
    {
        _navigationManager.NavigateTo($"EditAdult/{adultId}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IService<Adult> _adultService { get; set; }
    }
}
#pragma warning restore 1591
