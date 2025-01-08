// class類別 & object物件

// 主程式檔

// 創建物件
Person person1 = new Person(); // 以Person類別 創建Person實體（物件），命名為person1（變數）
// 為物件屬性新增值
person1.height = 160.5;
person1.age = 18;
person1.name = "小黑";

// 創建物件
Person person2 = new Person(); // 以Person類別 創建Person實體（物件），命名為person2（變數）
// 為物件屬性新增值
person1.height = 153.5;
person1.age = 27;
person1.name = "小白";

System.Console.WriteLine(person1.height); // 印出person1物件的height屬性之值
System.Console.WriteLine(person2.height);

//---------不同檔案分隔線----------

// Person.cs檔

// 創建類別
class Person // 類別命名慣例首字母大寫 // 創建資料型態之模版
{
	public double height; // 屬性
	public int age;
	public string name;
}