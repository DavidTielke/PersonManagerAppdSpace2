﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleClient.DataClasses;

namespace ConsoleClient
{
    public class PersonManager
    {
        private readonly PersonRepository _repository;

        public PersonManager()
        {
            _repository = new PersonRepository();
        }

        public IQueryable<Person> GetAllAdults()
        {
            var adults = _repository
                .Query()
                .Where(p => p.Age >= 18);
            return adults;
        }

        public IQueryable<Person> GetAllChildren()
        {
            var children = _repository
                .Query()
                .Where(p => p.Age < 18);
            return children;
        }


        public Person Copy(Person person)
        {
            return person;
        }
    }
}