// 字串常見的用法

// 換行
System.Console.WriteLine("Hello \nMr.White"); // \n為換行

// 雙引號（逸脫字元）
System.Console.WriteLine("Hello\" Mr.White");

// 字串相加
System.Console.WriteLine("Hello" + "Mr.White");

// 變數串接
string phrase = "Hello";
System.Console.WriteLine(phrase + "Mr.White");

// 計算字串長度
string phrase2 = "Hello Mr.White";
System.Console.WriteLine(phrase.Length); // 輸出14（14個字（含空白））
System.Console.WriteLine("Hello Mr.White".Length); // 輸出14

// 轉大寫
System.Console.WriteLine(phrase.ToUpper());

// 轉小寫
System.Console.WriteLine(phrase.ToLower());

// 判斷是否含有特定子字串
System.Console.WriteLine(phrase.Contains("Hello")); // 輸出 True
System.Console.WriteLine(phrase.Contains("qq")); // 輸出 False

// 查看字串中特定位置的值
System.Console.WriteLine(phrase[1]); // 輸出 e

// 查看字串中特定值的位置
// 字元
System.Console.WriteLine(phrase.IndexOf('l')); // 輸出 2（第一個l的位置）
// 字串
System.Console.WriteLine(phrase.IndexOf("White")); // 輸出 9（回傳字串開頭位置）
// Hello Mr.White
// 0123456789
System.Console.WriteLine(phrase.IndexOf("qq")); // 輸出 -1（所要尋找的值不存在）

// 切割字串
System.Console.WriteLine(phrase.Substring(2)); // 輸出 llo Mr.White（從第二位開始做切割 第二位前的字串都刪除）
System.Console.WriteLine(phrase.Substring(6,3)); // 輸出 Mr.（從第6位開始做切割，往後只要3位）