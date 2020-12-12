using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntryPoint___test_task.Models;
using EntryPoint___test_task.Data;

namespace EntryPoint___test_task.ViewModels
{
    public class dataIndex : Controller
    {
        public IEnumerable<Client> Clients { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}
