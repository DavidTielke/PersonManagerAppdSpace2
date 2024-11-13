﻿using ConsoleClient.DataClasses;

namespace ConsoleClient;

public interface IPersonManager
{
    IQueryable<Person> GetAllAdults();
    IQueryable<Person> GetAllChildren();
}