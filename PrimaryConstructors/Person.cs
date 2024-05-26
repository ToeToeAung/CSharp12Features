using System;

public class Person(string name)
{
	public void Test()
	{
	Console.WriteLine(name);
	}
}

record User(String Name);
