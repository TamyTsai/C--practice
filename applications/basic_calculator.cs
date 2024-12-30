// 基本計算機

System.Console.Write("請輸入第一個數：");
// string num1 = System.Console.ReadLine(); // 預設回傳字串型態
// int num1 = System.Console.ReadLine(); // 會報錯 因為字串無法存入型態為整數的變數中
// int num1 = System.Convert.ToInt32(System.Console.ReadLine()); // 將使用者輸入轉換為數字 再存入型態為整數的變數中 但做有小數點的運算會當掉
double num1 = System.Convert.ToDouble(System.Console.ReadLine());
System.Console.Write("請輸入第二個數：");
double num2 = System.Convert.ToDouble(System.Console.ReadLine());
System.Console.WriteLine(num1 + num2);