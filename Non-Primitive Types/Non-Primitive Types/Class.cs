using System;
using Non_Primitive_Types.Math;

namespace nonTypes;

class Type
{

    static void Main(string[] args)
    {
        Person Tim = new Person();
        Tim.Name = "Tim";
        Tim.lastname = "Sander";
        Tim.introduce();

        Calculator Calculator = new Calculator();
        int result = Calculator.Add(1, 2);
        Console.WriteLine(result);
    }
}
