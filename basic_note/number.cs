// 數字常見的用法（整數、浮點數）

// 整數運算
System.Console.WriteLine(5+2); // 輸出7
System.Console.WriteLine(5*2); // 輸出10
System.Console.WriteLine(5/2); // 輸出2 整數除以整數 得到整數

// 輸出浮點數
System.Console.WriteLine(5/2.0); // 輸出2.5
System.Console.WriteLine(5.0/2); // 輸出2.5（其中一邊是浮點數就可以輸出浮點數）

// 先乘除後加減
System.Console.WriteLine(5+3*2); // 輸出11

// 括弧內優先
System.Console.WriteLine((5+2)*3); // 輸出21

// 存入變數作運算
int num = 3;
System.Console.WriteLine((5+2)*num); // 輸出21

// 絕對值
System.Console.WriteLine(System.Math.Abs(-10)); // 輸出10

// 次方
System.Console.WriteLine(System.Math.Pow(4, 3)); // 輸出64

// 開根號
System.Console.WriteLine(System.Math.Sqrt(64)); // 輸出8

// 取極大值
System.Console.WriteLine(System.Math.Max(2, 100)); // 輸出100

// 取極小值
System.Console.WriteLine(System.Math.Min(2, 100)); // 輸出2

// 四捨五入
System.Console.WriteLine(System.Math.Round(3.4)); // 輸出3