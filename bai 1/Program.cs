using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    public static int Main(string[] args)
    {
        bai1 bai = new bai1();
        bai.bai1a();
        bai.bai1b();
        userData userData= new userData(1302,"Casfhf",124);
        userData.showData();
        Console.ReadLine();
        return 0;
    }
}
