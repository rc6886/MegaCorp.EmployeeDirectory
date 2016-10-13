using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Megacorp.ElasticSearch;
using Nest;

namespace Megacorp.SearchHost
{
    class Program
    {
        static void Main(string[] args)
        {
            //var employee = new Employee
            //{
            //    Id = 1,
            //    FirstName = "John",
            //    LastName = "Smith",
            //    Age = 25,
            //    About = "I love to go rock climbing",
            //    Interests = new[] {"Sports", "Music"},
            //};

            //var employee2 = new Employee
            //{
            //    Id = 2,
            //    FirstName = "Hane",
            //    LastName = "Smith",
            //    Age = 32,
            //    About = "I like to collect rock albums",
            //    Interests = new[] { "Music" },
            //};

            //var employee3 = new Employee
            //{
            //    Id = 3,
            //    FirstName = "Douglas",
            //    LastName = "Fir",
            //    Age = 35,
            //    About = "I like to build cabinets",
            //    Interests = new[] { "Forestry" },
            //};

            var elasticClient = new ElasticSearchClient();
            //var response = elasticClient.Get<Employee>("megacorp", "employee", "_search");
            //Console.WriteLine(response);

            var response = elasticClient.Search<Employee>("megacorp", "employee", "Smith");
            Console.WriteLine(response);
            ////var response = elasticClient.Index(employee, "megacorp", "employee");
            //var response = elasticClient.Index(employee2, "megacorp", "employee");
            //Console.WriteLine(response);
            //response = elasticClient.Index(employee3, "megacorp", "employee");
            //Console.WriteLine(response);
        }
    }
}
