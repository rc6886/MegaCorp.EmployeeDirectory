﻿using System.Collections.Generic;

namespace Megacorp.ElasticSearch
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string About { get; set; }
        public IEnumerable<string> Interests { get; set; }
    }
}
