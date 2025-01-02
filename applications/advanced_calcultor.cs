// 進階計算機

System.Console.Write("請輸入第一個數："); // 不換行
double num1 = System.Convert.ToDouble(System.Console.ReadLine()); // 取得用戶的輸入 並將用戶輸入由字串轉為double型態 再存入double型態之變數中

System.Console.Write("請輸入要做的運算：");
string oper = System.Console.ReadLine();

System.Console.Write("請輸入第二個數：");
double num2 = System.Convert.ToDouble(System.Console.ReadLine());

if (oper == "+")
{
	System.Console.WriteLine(num1 + num2);
}
else if (oper == "-")
{
	System.Console.WriteLine(num1 - num2);
}
else if (oper == "*")
{
	System.Console.WriteLine(num1 * num2);
}
else if (oper == "/")
{
	System.Console.WriteLine(num1 / num2);
}
else
{
	System.Console.WriteLine("不合法的運算符號");
}