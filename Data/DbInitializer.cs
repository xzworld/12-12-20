using EntryPoint___test_task.Models;
using System;
using System.Linq;

namespace EntryPoint___test_task.Data
{
    public static class DbInitializer
    {
        public static void Initialize(DbTestcontext context)
        {
            context.Database.EnsureCreated();

            // Look for any Clients.
            if (context.Clients.Any())
            {
                return;   // DB has been seeded
            }

            var Clients = new Client[]
            {
            new Client{Name="Carson",Email="Alexander@gmail.com",Birthdate=DateTime.Parse("2005-09-01"),Gender=Gender.Male,Orders=null},
            new Client{Name="Meredith",Email="Alonso@gmail.com",Birthdate=DateTime.Parse("2002-09-01"),Gender=Gender.Male,Orders=null},
            new Client{Name="Arturo",Email="Anand@gmail.com",Birthdate=DateTime.Parse("2003-09-01"),Gender=Gender.Male,Orders=null},
            new Client{Name="Gytis",Email="Barzdukas@gmail.com",Birthdate=DateTime.Parse("2002-09-01"),Gender=Gender.Male,Orders=null},
            new Client{Name="Yan",Email="Li@gmail.com",Birthdate=DateTime.Parse("2002-09-01"),Gender=Gender.Female,Orders=null},
            new Client{Name="Peggy",Email="Justice@gmail.com",Birthdate=DateTime.Parse("2001-09-01"),Gender=Gender.Female,Orders=null},
            new Client{Name="Laura",Email="Norman@gmail.com",Birthdate=DateTime.Parse("2003-09-01"),Gender=Gender.Female,Orders=null},
            new Client{Name="Nino",Email="Olivetto@gmail.com",Birthdate=DateTime.Parse("2005-09-01"),Gender=Gender.Female,Orders=null}
            };
            foreach (Client s in Clients)
            {
                context.Clients.Add(s);
            }
            context.SaveChanges();

            var Products = new Product[]
            {
            new Product{Code="e45vg465vg46ev6",Title="Chemistry",Price=99.7M},
            new Product{Code="234985784334565467",Title="Microeconomics",Price=9.7M},
            new Product{Code="234546fgd565467",Title="Macroeconomics",Price=11.17M},
            new Product{Code="143143vf3352v35",Title="Calculus",Price=199.21M},
            new Product{Code="235v35v32v5",Title="Trigonometry",Price=199.09M},
            new Product{Code="45gv654665467",Title="Composition",Price=99.99M},
            new Product{Code="23v53v53v532v523",Title="Literature",Price=999.99M}
            };
            foreach (Product c in Products)
            {
                context.Products.Add(c);
            }
            context.SaveChanges();

            var Orders = new Order[]
            {
            new Order{ClientId=1,Client="",ProductId=1050,Products=null,Quantity=1,Status=Status.Delivered},
            new Order{ClientId=1,Client="",ProductId=4022,Products=null,Quantity=2,Status=Status.Created},
            new Order{ClientId=1,Client="",ProductId=4041,Products=null,Quantity=5,Status=Status.Paid},
            new Order{ClientId=2,Client="",ProductId=1045,Products=null,Quantity=2,Status=Status.Paid},
            new Order{ClientId=2,Client="",ProductId=3141,Products=null,Quantity=1,Status=Status.Created},
            new Order{ClientId=2,Client="",ProductId=2021,Products=null,Quantity=56,Status=Status.Created},
            new Order{ClientId=3,Client="",ProductId=1050,Products=null,Quantity=1,Status=Status.Created},
            new Order{ClientId=4,Client="",ProductId=1050,Products=null,Quantity=4,Status=Status.Created},
            new Order{ClientId=4,Client="",ProductId=4022,Products=null,Quantity=12,Status=Status.Created},
            new Order{ClientId=5,Client="",ProductId=4041,Products=null,Quantity=2,Status=Status.Created},
            new Order{ClientId=6,Client="",ProductId=1045,Products=null,Quantity=1,Status=Status.Created},
            new Order{ClientId=7,Client="",ProductId=3141,Products=null,Quantity=8,Status=Status.Delivered},
            };
            foreach (Order e in Orders)
            {
                context.Orders.Add(e);
            }
            context.SaveChanges();
        }
    }
}