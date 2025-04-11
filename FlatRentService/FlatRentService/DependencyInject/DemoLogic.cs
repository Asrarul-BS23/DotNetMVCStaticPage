using Microsoft.EntityFrameworkCore;

namespace FlatRentService.DependencyInject;

public class DemoLogic : IDemoLogic
{
    public int Value1 { get; private set; }
    public int Value2 { get; private set; }

    public DemoLogic()
    {
        Value1 = Random.Shared.Next(0, 10000);
        Value2 = Random.Shared.Next(0, 10000);
    }
}