using ConsoleClient.DataClasses;

namespace ConsoleClient;

public interface IPersonParser
{
    Person ParseFromCsv(string dataLine);
}