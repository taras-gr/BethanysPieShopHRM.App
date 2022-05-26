using BethanysPieShopHRM.App.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.AspNetCore.Components.WebAssembly.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.ClientSideBlazor
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<BethanysPieShopHRM.App.App>("#app");

            builder.Services.AddHttpClient<IEmployeeDataService, EmployeeDataService>(client => client.BaseAddress = new Uri("https://localhost:44340"));
            builder.Services.AddHttpClient<ICountryDataService, CountryDataService>(client => client.BaseAddress = new Uri("https://localhost:44340"));
            builder.Services.AddHttpClient<IJobCategoryDataService, JobCategoryDataService>(client => client.BaseAddress = new Uri("https://localhost:44340"));
            builder.Services.AddScoped<LazyAssemblyLoader>();

            await builder.Build().RunAsync();
        }
    }
}