//Fenix Strickland
//MIS 3033 001 September 1 2022
//Simple vs Complex
//class

//Simple vs complex

//Simple: int, bool, double, char
//Complex: string,
// datatype variable_name;
//double _stuWeightDbl; //101
//_stuWeightDbl = 120.8;

//double _stuWeightDbl2;//103
//_stuWeightDbl2 = _stuWeightDbl; //copies 120.8 instead of 101... Two different rooms same content inside


//string _stuNameStr;
////_stuNameStr = "Fenix Strickland";
//// new Datatype(..)
//_stuNameStr = new string("Fenix Strickland"); //102 this part creates space in the computer memory

//string _stuNameStr2;
//_stuNameStr2 = _stuNameStr; //copy room number 102 .. two cards that have access to the same room


// Define new datatype using class
// Complex

Person p1;
p1 = new Person();//104
//p1.name = new string("Fenix Strickland");
p1.name = "Fenix Strickland";
p1.weight = 155.5;
p1.age = 22;

string infoStr = p1.GetPersonInfor();
Console.WriteLine(infoStr);

Console.ReadLine();

//class DataTypeName 
//{ }

public class Person
{
    public string name;
    public int age;
    public double weight;

    public string GetPersonInfor()
    {
        string perInfoStr = string.Format($"The name is {name}\n The age is {age}\n The weiht is {weight:f2}");
        return perInfoStr;
    }

    //DataType function_name()
    //{
        //...
        //return data;
    //}

}
