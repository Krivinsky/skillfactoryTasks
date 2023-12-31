﻿class Program
{
    static void Main(string[] args)
    {
        var department = GetCurrentDepartment();
        if (department?.Company?.Type == "Банк" && department?.City?.Name == "Санкт-Петербург")
            Console.WriteLine("У банка {0} есть отделение в Санкт-Петербурге", department?.Company?.Type ?? "Неизвестная компания");
        Console.WriteLine("У банка" + department.Company + " есть отделение в Санкт-Петербурге");
    }

    static Department GetCurrentDepartment()
    {
        return new Department();
    }
}


class Company
{
    public string Type;
    public string Name;
}

class Department
{
    public Company Company;
    public City City;
}

class City
{

    public string Name;
}


class Bus
{
    public int? Load;

    public void PrintStatus()
    {
        //Console.WriteLine(Load ?? );
    }
}