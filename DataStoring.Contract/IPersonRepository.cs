﻿using ConsoleClient.DataClasses;

namespace ConsoleClient;

public interface IPersonRepository
{
    IQueryable<Person> Query();
}