using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleClient.DataClasses;

namespace ConsoleClient
{
    public class PersonParser : IPersonParser
    {
        public Person ParseFromCsv(string dataLine)
        {
            var parts = dataLine.Split(",");
            var person = new Person
            {
                Id = int.Parse(parts[0]),
                Name = parts[1],
                Age = int.Parse(parts[2]),
            };
            return person;
        }
    }
}