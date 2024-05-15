using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

public  class UserData
{
    public int ID;
    public string Name;
    public List<float> Score;
    public UserData()
    {
        ID = 0;
        Name = "null";
        Score = new List<float>();
    }
    public UserData(int iD, string name, List<float> score)
    {
        ID = iD;
        Name = name;
        Score = score;
    }
    public void showData()
    {
        UserData userData = new UserData();
        Console.WriteLine("Nhap Id: ");

        String id = Console.ReadLine();

        userData.ID = Convert.ToInt32(id);

        Console.WriteLine("UserData.id: " + userData.ID);

        Console.WriteLine("Nhap danh sach Diem: ");
        Console.WriteLine("So Luong diem can nhap: ");
        int soLuongDiem = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < soLuongDiem; i++)
        {
            Console.WriteLine("Nhap diem: ");
            String diem = Console.ReadLine();
            userData.Score.Add(Convert.ToInt32(diem));
        }


        /*string[] strings = danhSachDiem.Split(" ");
        foreach (string s in strings)
        {
            userData.scoreList.Add(Convert.ToDouble(s));
        }*/
        foreach (double score in userData.Score)
        {
            Console.WriteLine("Diem: " + score);
        }
    }
}
