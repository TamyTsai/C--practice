// method 方法

// 主程式檔
using ConsoleApp1;
using System;

Person person1 = new Person(); 
// 為物件屬性新增值
person1.height = 160.5;
person1.age = 18;
person1.name = "小黑";
person1.SayHi(); // 會執行SayHi方法中的程式碼
// 用person1物件 呼叫SayHi方法
Console.WriteLine(person1.IsAdult()); // 呼叫方法 方法有回傳值 就會覆蓋過呼叫的地方
// 「person1.IsAdult()」被方法回傳的「true」覆蓋
// 因為可能還要做後續的處理 所以方法只return值就好
Console.WriteLine(person1.Add(2,3,"pwd")); // 印出5 // 呼叫方法時 傳值進去
// 參數引數個數需相同
// WriteLine為內建之不回傳值的方法

//---------不同檔案分隔線----------

// Person.cs檔
using System;

namespace ConsoleApp1
{
	class Person
	{
		public double height;
		public int age;
		public string name;
		
		public void SayHi() // 定義Person類別中的功能（方法）// void表示此方法不回傳值
		{
			Console.WriteLine("你好啊，我是" + name);
		}
		
		public bool IsAdult() // 要寫要回傳的值的資料型態
		{
			if(age >= 18)
			{
				return true;
			}	
			else
			{
				return false;
			}
		}
		
		public int Add(int num1, int num2, string qq) // 有參數的方法 // 參數可以有不同資料型態
		{
			return num1 + num2;
		}
	}
}