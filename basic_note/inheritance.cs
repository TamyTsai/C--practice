// 繼承inheritance

// 主程式檔案
using ConsoleApp1;
using System;

Student student1 = new Student("小白", 15, "某某國中");

Console.WriteLine(student1.name); // 因為Student類別有繼承Person類別，所以像name這種寫在Person類別中的屬性，以Student類別創建出的物件也可以用
student1.PrintAge(); // 因為Student類別有繼承Person類別，所以像PrintAge()這種寫在Person類別中的方法，以Student類別創建出的物件也可以用

//---------不同檔案分隔線----------

// Person.cs檔

class Person
{
	public string name;
	public int age;
	public void PrintAge()
	{
		Console.WriteLine(this.age);
	}
	public void PrintName()
	{
		Console.WriteLine(this.name);
	}
}


//---------不同檔案分隔線----------

// Student.cs檔

class Student : Person // Student類別繼承Person類別中的所有 屬性 與 方法
{
	public string school;
	public Student(string name, int age, string school) // 建構方法
	{
		this.name = name;
		this.age = age;
		this.school = school;
	}
	
	public void PrintSchool() 
	{
		Console.WriteLine(this.school);
	}
}
