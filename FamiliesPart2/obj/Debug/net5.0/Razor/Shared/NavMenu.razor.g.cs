#pragma checksum "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cb0eac60323fffd4ec0bc2aab6030e21e2b98ca"
// <auto-generated/>
#pragma warning disable 1591
namespace FamiliesPart2.Shared
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
#line 1 "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\Shared\NavMenu.razor"
using FamiliesPart2.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\Shared\NavMenu.razor"
using FamiliesPart2.Data;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddAttribute(2, "b-4zga7fgm8y");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href b-4zga7fgm8y>FamiliesPart2</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-4zga7fgm8y");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-4zga7fgm8y></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 13 "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "b-4zga7fgm8y");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddAttribute(16, "b-4zga7fgm8y");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddAttribute(19, "b-4zga7fgm8y");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "Login");
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(24, "<span class=\"oi oi-laptop\" aria-hidden=\"true\" b-4zga7fgm8y></span> Login\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(26);
            __builder.AddAttribute(27, "class", "nav-link");
            __builder.AddAttribute(28, "href", "RegisterUser");
            __builder.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(30, "<span class=\"oi oi-telephone\" aria-hidden=\"true\" b-4zga7fgm8y></span> Register Account\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(32);
            __builder.AddAttribute(33, "Policy", " ");
            __builder.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(35, "li");
                __builder2.AddAttribute(36, "class", "nav-item px-3");
                __builder2.AddAttribute(37, "b-4zga7fgm8y");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(38);
                __builder2.AddAttribute(39, "class", "nav-link");
                __builder2.AddAttribute(40, "href", "");
                __builder2.AddAttribute(41, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 25 "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\Shared\NavMenu.razor"
                                                         NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(43, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-4zga7fgm8y></span> Home\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n            ");
                __builder2.OpenElement(45, "li");
                __builder2.AddAttribute(46, "class", "nav-item px-3");
                __builder2.AddAttribute(47, "b-4zga7fgm8y");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(48);
                __builder2.AddAttribute(49, "class", "nav-link");
                __builder2.AddAttribute(50, "href", "Families");
                __builder2.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(52, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-4zga7fgm8y></span> Families\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n            ");
                __builder2.OpenElement(54, "li");
                __builder2.AddAttribute(55, "class", "nav-item px-3");
                __builder2.AddAttribute(56, "b-4zga7fgm8y");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(57);
                __builder2.AddAttribute(58, "class", "nav-link");
                __builder2.AddAttribute(59, "href", "Adults");
                __builder2.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(61, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-4zga7fgm8y></span> Adults\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n            ");
                __builder2.OpenElement(63, "li");
                __builder2.AddAttribute(64, "class", "nav-item px-3");
                __builder2.AddAttribute(65, "b-4zga7fgm8y");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(66);
                __builder2.AddAttribute(67, "class", "nav-link");
                __builder2.AddAttribute(68, "href", "SecurityLevel");
                __builder2.AddAttribute(69, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(70, "<span class=\"oi oi-list\" aria-hidden=\"true\" b-4zga7fgm8y></span> Security Level\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(71, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(72);
            __builder.AddAttribute(73, "Policy", "MustBeManager");
            __builder.AddAttribute(74, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(75, "li");
                __builder2.AddAttribute(76, "class", "nav-item px-3");
                __builder2.AddAttribute(77, "b-4zga7fgm8y");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(78);
                __builder2.AddAttribute(79, "class", "nav-link");
                __builder2.AddAttribute(80, "href", "AddAdult");
                __builder2.AddAttribute(81, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(82, "<span class=\"oi oi-arrow-right\" aria-hidden=\"true\" b-4zga7fgm8y></span> Add New Adult\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n            ");
                __builder2.OpenElement(84, "li");
                __builder2.AddAttribute(85, "class", "nav-item px-3");
                __builder2.AddAttribute(86, "b-4zga7fgm8y");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(87);
                __builder2.AddAttribute(88, "class", "nav-link");
                __builder2.AddAttribute(89, "href", "AddFamily");
                __builder2.AddAttribute(90, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(91, "<span class=\"oi oi-arrow-right\" aria-hidden=\"true\" b-4zga7fgm8y></span> Add New Family\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider StateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
