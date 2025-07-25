using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.Dashboards
{
    public class DashboardDto : IDto
    {
        public int SalesOfDaily {  get; set; }
        public int SalesOfMonth {  get; set; }
        public decimal IncomeOfDaily { get; set; }
        public decimal IncomeOfMonth { get; set; }
        public string? NetSalesOfYesterday {  get; set; }
        public string? NetSalesOfMonth { get; set; }
        public string? NetIncomeOfYesterday { get; set; }
        public string? NetIncomeOfMonth { get; set; }
    }

}
