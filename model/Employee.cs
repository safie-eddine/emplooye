using System;

struct Employee
{
    public int id { get; set; }
    public string name { get; set; }
    public float salary { get; set; }
    public Employee(int id, String name, float salary )
    {
        this.id = id;
        this.name = name;
        this.salary = salary;

    }
}
