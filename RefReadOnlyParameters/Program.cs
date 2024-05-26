
var example = new Example();
var age = 30;
example.Test(ref age);
Console.WriteLine($"The age is : {age}");

public class Example(){
    public void Test(ref int age){
        Console.WriteLine($"The age is : {age}");
        age++;
    }
}