#pragma checksum "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\Pages\Adults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a76c91a45927014b977cf0a77612a5f8d93def53"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h3>Adults</h3>\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Search by First Name:");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "text");
            __builder.AddAttribute(5, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\Pages\Adults.razor"
                                                       (arg) => Filter(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "style", "width: 200px");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 12 "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\Pages\Adults.razor"
 if (adultsToShow == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<p><em>Loading...</em></p>");
#nullable restore
#line 17 "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\Pages\Adults.razor"
}
else if (!adultsToShow.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, "<p><em>No Adults registred!</em></p>");
#nullable restore
#line 23 "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\Pages\Adults.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "table");
            __builder.AddAttribute(10, "class", "table table-striped");
            __builder.AddMarkupContent(11, @"<thead><tr><th scope=""col"">Id</th>
                <th scope=""col"">First Name</th>
                <th scope=""col"">Last Name</th>
                <th scope=""col"">Hair Color</th>
                <th scope=""col"">Age</th>
                <th scope=""col"">Weight</th>
                <th scope=""col"">Height</th>
                <th scope=""col"">Sex</th>
                <th scope=""col"">Job Title</th>
                <th scope=""col"">Salary</th></tr></thead>
        ");
            __builder.OpenElement(12, "tbody");
#nullable restore
#line 42 "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\Pages\Adults.razor"
         foreach (var adult in adultsToShow)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "tr");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 45 "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\Pages\Adults.razor"
                     adult.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 46 "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\Pages\Adults.razor"
                     adult.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 47 "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\Pages\Adults.razor"
                     adult.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 48 "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\Pages\Adults.razor"
                     adult.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 49 "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\Pages\Adults.razor"
                     adult.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 50 "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\Pages\Adults.razor"
                     adult.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 51 "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\Pages\Adults.razor"
                     adult.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 52 "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\Pages\Adults.razor"
                     adult.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 53 "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\Pages\Adults.razor"
                     adult.JobTitle.JobTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.OpenElement(41, "td");
            __builder.AddContent(42, 
#nullable restore
#line 54 "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\Pages\Adults.razor"
                     adult.JobTitle.Salary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                \r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(44);
            __builder.AddAttribute(45, "Policy", "MustBeManager");
            __builder.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(47, "td");
                __builder2.OpenElement(48, "button");
                __builder2.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\Pages\Adults.razor"
                                            () => RemoveAdultAsync(adult.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(50, "<i class=\"oi oi-trash\" style=\"color: red\"></i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n                    ");
                __builder2.OpenElement(52, "td");
                __builder2.OpenElement(53, "button");
                __builder2.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\Pages\Adults.razor"
                                          () => EditAdultAsync(adult.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(55, "<i class=\"oi oi-pencil\" style=\"color: #2efff8\"></i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 70 "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\Pages\Adults.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 73 "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\Pages\Adults.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 75 "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\Pages\Adults.razor"
       
    private IList<Adult> adultsToShow;
    private IList<Adult> adults;
    private string filterByName;
    
    protected override async Task OnInitializedAsync()
    {
        adultsToShow = await AdultService.GetAllAdultsAsync();
    }

    private void Filter(ChangeEventArgs changeEventArgs)
    {
        filterByName = null;
        try
        {
            filterByName = changeEventArgs.Value.ToString();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        ExecuteFilter();
    }

    private void ExecuteFilter()
    {
        adultsToShow = adults.Where(a => a.FirstName.Equals(filterByName)).ToList();
    }

    private async Task RemoveAdultAsync(int adultId)
    {
        Adult adultToRemove = adults.First(a => a.Id == adultId);
        await AdultService.RemoveAdultAsync(adultId);
        adultsToShow.Remove(adultToRemove);
        adults.Remove(adultToRemove);
    }

    private async Task EditAdultAsync(int adultId)
    {
        NavigationManager.NavigateTo($"EditAdult/{adultId}");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultService AdultService { get; set; }
    }
}
#pragma warning restore 1591
