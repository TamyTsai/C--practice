// namespace、using
// namespace用來管理模版

// 主程式檔

/*
Animal.Person person1 = new Animal.Person(); // 以Animal命名空間中的Person類別 創建Person實體（物件），命名為person1（變數）
// 為物件屬性新增值
person1.height = 160.5;
person1.age = 18;
person1.name = "小黑";
*/

using Animal.qq; // 本檔案創建物件都用Animal命名空間下的qq命名空間下的類別
using System;

Person person1 = new Person(); // 以Animal命名空間下的qq命名空間中的Person類別 創建Person實體（物件），命名為person1（變數）
// 為物件屬性新增值
person1.height = 160.5;
person1.age = 18;
person1.name = "小黑";

// System是C#內建的namespace
// Console是System命名空間下的class
Console.WriteLine(person1.name);

//---------不同檔案分隔線----------


// Person.cs檔
namespace Animal // namespace是一個可以拿來存放很多模版（class）的空間，用以將模版做分類、管理
{
	namespace qq // namespace裡面還可以再加namespace
	{ 
		class Person 
		{
			public double height; // 屬性
			public int age;
			public string name;
		}
	}
}

namespace House
{

}