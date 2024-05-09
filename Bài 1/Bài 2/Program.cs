using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.CompilerServices;

public class Maps
{
    public string ID;
    public string UserName;
    public static string InGame = " Lien Minh Huyen Thoai";

    public Maps(string ID, string UserName)
    {
        this.ID = ID;
        this.UserName = UserName;
    }

    public string ShowData()
    {
        return "ID: " + ID + " |Name: " + UserName + " |inGame: " + InGame;
    }
}
public class Program
{
    public static int Main(string[] args)
    {
       Maps maps = new Maps("2024", "URF");
        Console.WriteLine(maps.ShowData());
        return 0;
    }
}