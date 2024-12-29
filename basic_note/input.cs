// 取得用戶輸入

System.Console.WriteLine("請輸入您的名字："); // 有換行
System.Console.Write("請輸入您的名字："); // 沒換行
string name = System.Console.ReadLine(); // 用戶輸入的結果會被回傳 覆蓋呼叫其的程式碼
System.Console.Write("請輸入您的年紀：");
string age = System.Console.ReadLine();
System.Console.WriteLine("你好啊" + name + "你今年" + age + "歲");