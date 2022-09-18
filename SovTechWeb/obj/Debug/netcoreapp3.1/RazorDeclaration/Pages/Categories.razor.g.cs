// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SovTechWeb.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\aiyetanm\Downloads\sovtech-backend-main\sovtech-backend-main\SovTechWeb\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aiyetanm\Downloads\sovtech-backend-main\sovtech-backend-main\SovTechWeb\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\aiyetanm\Downloads\sovtech-backend-main\sovtech-backend-main\SovTechWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\aiyetanm\Downloads\sovtech-backend-main\sovtech-backend-main\SovTechWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\aiyetanm\Downloads\sovtech-backend-main\sovtech-backend-main\SovTechWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\aiyetanm\Downloads\sovtech-backend-main\sovtech-backend-main\SovTechWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\aiyetanm\Downloads\sovtech-backend-main\sovtech-backend-main\SovTechWeb\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\aiyetanm\Downloads\sovtech-backend-main\sovtech-backend-main\SovTechWeb\_Imports.razor"
using SovTechWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\aiyetanm\Downloads\sovtech-backend-main\sovtech-backend-main\SovTechWeb\_Imports.razor"
using SovTechWeb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\aiyetanm\Downloads\sovtech-backend-main\sovtech-backend-main\SovTechWeb\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\aiyetanm\Downloads\sovtech-backend-main\sovtech-backend-main\SovTechWeb\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\aiyetanm\Downloads\sovtech-backend-main\sovtech-backend-main\SovTechWeb\Pages\Categories.razor"
using SovTechWeb.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\aiyetanm\Downloads\sovtech-backend-main\sovtech-backend-main\SovTechWeb\Pages\Categories.razor"
using SovTechWeb.Service.Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\aiyetanm\Downloads\sovtech-backend-main\sovtech-backend-main\SovTechWeb\Pages\Categories.razor"
using SovTechWeb.Service.Response;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class Categories : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "C:\Users\aiyetanm\Downloads\sovtech-backend-main\sovtech-backend-main\SovTechWeb\Pages\Categories.razor"
       
        private WeatherForecast[] forecasts;
        string categoryDetails;

        public List<string> category { get; set; } = new List<string>();

        public CategoryDetailResponse categoryDetailResponse { get; set; } = new CategoryDetailResponse();


        protected override async Task OnInitializedAsync()
        {
           category = await service.GetJokeCategoriesAsync();
        }

        [Parameter]
        public bool showModal { get; set; }

        public async Task ModalShow(string categoryDetails)
        {
           showModal = true;
           categoryDetailResponse = await service.GetRandomJoke(categoryDetails);
        }

        public void ModalCancel() => showModal = false;
        public void ModalOk()
        {
           Console.WriteLine("Modal ok");
           showModal = false;
        }



   

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISOvTechService service { get; set; }
    }
}
#pragma warning restore 1591
