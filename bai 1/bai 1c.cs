using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class userData
{
    public int ID;
    public string userName;
    public int level;
    public userData(int ID, string userName, int level)
    {
        this.ID = ID;
        this.userName = userName;
        this.level = level;
    }
    public void showData()
    {
        Console.WriteLine("ID: " + ID);
        Console.WriteLine("User name : " + userName);
        Console.WriteLine("Level: " + level);

    }
    public void showData(dynamic attribute)
    {
        Console.WriteLine(attribute);
    }
    
}

