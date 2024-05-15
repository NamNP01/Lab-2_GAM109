using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public partial class bai2
{
    public void Bai2a()
    {
        var userInfo = new
        {
            id = "123",
            name = "Faker",
            isDispay = false,
            bag = new
            {
                skins = 0,
                cups = 20,
            }
        };
        Console.WriteLine("id:" + userInfo.id);
        Console.WriteLine("name:" + userInfo.name);
        Console.WriteLine("isplaying:" + userInfo.isDispay);
        Console.WriteLine("bag cup:" + userInfo.bag.skins);
    }
}
