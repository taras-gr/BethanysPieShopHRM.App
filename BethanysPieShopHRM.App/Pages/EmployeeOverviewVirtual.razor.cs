using BethanysPieShopHRM.App.Services;
using BethanysPieShopHRM.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.App.Pages
{
    public partial class EmployeeOverviewVirtual
    {
        public List<Employee> Employees { get; set; } = new List<Employee>();

        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }

        private float ItemHeight = 50;

        protected async override Task OnInitializedAsync()
        {
            Employees = (await EmployeeDataService.GetLongEmployeeList()).ToList();
        }
    }
}
