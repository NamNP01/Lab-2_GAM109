using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public partial class bai1
{
    public void getDetail(dynamic value)
    {
        Console.WriteLine("Value: " + value);
    }

    public void bai1b()
    {
        Console.WriteLine("bai 1 b");

        getDetail(10);
        getDetail("game");
        getDetail(true);
        getDetail(9.5);
    }
}
