#pragma checksum "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87cd73bf4bf214fe466b0a64d97dc6e07bef7302"
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
#line 3 "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\Shared\NavMenu.razor"
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
#line 8 "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\Shared\NavMenu.razor"
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
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(26);
            __builder.AddAttribute(27, "Policy", "MustBeAnalyst");
            __builder.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(29, "li");
                __builder2.AddAttribute(30, "class", "nav-item px-3");
                __builder2.AddAttribute(31, "b-4zga7fgm8y");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(32);
                __builder2.AddAttribute(33, "class", "nav-link");
                __builder2.AddAttribute(34, "href", "");
                __builder2.AddAttribute(35, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 17 "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\Shared\NavMenu.razor"
                                                         NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(37, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-4zga7fgm8y></span> Home\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n            ");
                __builder2.OpenElement(39, "li");
                __builder2.AddAttribute(40, "class", "nav-item px-3");
                __builder2.AddAttribute(41, "b-4zga7fgm8y");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(42);
                __builder2.AddAttribute(43, "class", "nav-link");
                __builder2.AddAttribute(44, "href", "FamilyPage");
                __builder2.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(46, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-4zga7fgm8y></span> Families\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n            ");
                __builder2.OpenElement(48, "li");
                __builder2.AddAttribute(49, "class", "nav-item px-3");
                __builder2.AddAttribute(50, "b-4zga7fgm8y");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(51);
                __builder2.AddAttribute(52, "class", "nav-link");
                __builder2.AddAttribute(53, "href", "AdultPage");
                __builder2.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(55, "<span class=\"oi oi-arrow-right\" aria-hidden=\"true\" b-4zga7fgm8y></span> Adults\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n            ");
                __builder2.OpenElement(57, "li");
                __builder2.AddAttribute(58, "class", "nav-item px-3");
                __builder2.AddAttribute(59, "b-4zga7fgm8y");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(60);
                __builder2.AddAttribute(61, "class", "nav-link");
                __builder2.AddAttribute(62, "href", "SecurityLevel");
                __builder2.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(64, "<span class=\"oi oi-list\" aria-hidden=\"true\" b-4zga7fgm8y></span> Security Level\r\n                        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(65, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(66);
            __builder.AddAttribute(67, "Policy", "MustBeManager");
            __builder.AddAttribute(68, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(69, "li");
                __builder2.AddAttribute(70, "class", "nav-item px-3");
                __builder2.AddAttribute(71, "b-4zga7fgm8y");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(72);
                __builder2.AddAttribute(73, "class", "nav-link");
                __builder2.AddAttribute(74, "href", "");
                __builder2.AddAttribute(75, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 39 "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\Shared\NavMenu.razor"
                                                              NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(76, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(77, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-4zga7fgm8y></span> Home\r\n                         ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n                    ");
                __builder2.OpenElement(79, "li");
                __builder2.AddAttribute(80, "class", "nav-item px-3");
                __builder2.AddAttribute(81, "b-4zga7fgm8y");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(82);
                __builder2.AddAttribute(83, "class", "nav-link");
                __builder2.AddAttribute(84, "href", "FamilyPage");
                __builder2.AddAttribute(85, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(86, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-4zga7fgm8y></span> Families\r\n                        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n                    ");
                __builder2.OpenElement(88, "li");
                __builder2.AddAttribute(89, "class", "nav-item px-3");
                __builder2.AddAttribute(90, "b-4zga7fgm8y");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(91);
                __builder2.AddAttribute(92, "class", "nav-link");
                __builder2.AddAttribute(93, "href", "AdultPage");
                __builder2.AddAttribute(94, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(95, "<span class=\"oi oi-arrow-right\" aria-hidden=\"true\" b-4zga7fgm8y></span> Adults\r\n                        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n            ");
                __builder2.OpenElement(97, "li");
                __builder2.AddAttribute(98, "class", "nav-item px-3");
                __builder2.AddAttribute(99, "b-4zga7fgm8y");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(100);
                __builder2.AddAttribute(101, "class", "nav-link");
                __builder2.AddAttribute(102, "href", "AddAdult");
                __builder2.AddAttribute(103, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(104, "<span class=\"oi oi-arrow-right\" aria-hidden=\"true\" b-4zga7fgm8y></span> Add New Adult\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(105, "\r\n                    ");
                __builder2.OpenElement(106, "li");
                __builder2.AddAttribute(107, "class", "nav-item px-3");
                __builder2.AddAttribute(108, "b-4zga7fgm8y");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(109);
                __builder2.AddAttribute(110, "class", "nav-link");
                __builder2.AddAttribute(111, "href", "ManagerView");
                __builder2.AddAttribute(112, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(113, "<span class=\"oi oi-list\" aria-hidden=\"true\" b-4zga7fgm8y></span> Managers View\r\n                        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(114, "\r\n                    ");
                __builder2.OpenElement(115, "li");
                __builder2.AddAttribute(116, "class", "nav-item px-3");
                __builder2.AddAttribute(117, "b-4zga7fgm8y");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(118);
                __builder2.AddAttribute(119, "class", "nav-link");
                __builder2.AddAttribute(120, "href", "SecurityLevel");
                __builder2.AddAttribute(121, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(122, "<span class=\"oi oi-list\" aria-hidden=\"true\" b-4zga7fgm8y></span> Security Level\r\n                        ");
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
#line 71 "C:\Users\const\RiderProjects\FamiliesPart2\FamiliesPart2\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
