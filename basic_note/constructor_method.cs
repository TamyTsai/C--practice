// constructor建構方法
// 每創建一個物件 都會被呼叫的方法

// 主程式檔案

using ConsleApp1;
using System;

class Program
{
	static void Main()
	{
		// 創建物件（同時執行 建構方法Person()）
		Person person1 = new Person(160.5, 18, "小黑"); // 以Person類別 創建Person實體（物件），命名為person1（變數）
		Person person2 = new Person(153.5, 27, "小白"); // 以Person類別 創建Person實體（物件），命名為person2（變數）
		
		Console.WriteLine(person1.name);
		Console.WriteLine(person2.name);
	}
}

//---------不同檔案分隔線----------

// Person.cs檔

namespace ConsoleApp1
{
	class Person
	{
		public double height;
		public int age;
		public string name;
	}
	
	public Person(double height, int age, string name) // 建構方法 無法回傳資料 所以不用寫void或要回傳的資料之資料型態
	{ // 想要每創建一個物件，就執行一次的程式碼寫在這（初始方法）
		this.height = height; // 如果寫height=height，這兩個height都會抓到最近的height，也就是參數height，而非屬性height
		// this.height，表示這個height指的是這個類別中的屬性height
		this.age = age;
		this.name = name;
	}
}