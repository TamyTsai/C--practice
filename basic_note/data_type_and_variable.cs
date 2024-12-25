// 常見資料型態＆變數

// 常見資料型態
// 字串 string ""（一串純文字）
System.Console.WriteLine("你好");

// 字元 char ''（一個純文字）（似JAVA）
System.Console.WriteLine('你');

// 整數 int 40
System.Console.WriteLine(40);
System.Console.WriteLine(-40);

// 浮點數 double 160.5
System.Console.WriteLine(160.5);

// 布林值 bool true false
System.Console.WriteLine(true);
System.Console.WriteLine(false);

// 變數
// 創建變數（靜態）
string name = "小白";
char sex = 'M'; // 同一變數不能宣告兩次
double height = 180.3;
bool is_male = true;

System.Console.WriteLine("有一個人叫" + name); // 弱型別
name = "小黃"; // 修改變數中存放的值（但不能改變資料型態）
System.Console.WriteLine(name + "今年87歲");
System.Console.WriteLine(name + "身高" + height + "公分");
System.Console.WriteLine(name + "討厭自己87歲");