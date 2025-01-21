// static method靜態方法 & static class靜態類別

// 主程式檔案
using ConsoleApp1;
using System;

Console.WriteLine(Math.Sqrt(36));
// Math類別下的Sqrt方法
// 但不用創建math物件就可以使用Sqrt方法，因為Sqrt是靜態方法，可以直接作用在「類別」上

Tool.SayHi();
// 印出 Hello

// Math math = new Math(); // 會報錯
// 因為Math是靜態類別，所以無法用其創建物件（Math只是一個工具包，沒有用其創造物件的必要，所以該類別被設定為靜態類別）

// Food food = new Food(); // 會報錯


//---------不同檔案分隔線----------

// Tool.cs檔案

using System;

namespace ConsoleApp1;
{
	class Tool
	{
		public static void SayHi() // 創建靜態方法，作用於「類別」上
		{
			Console.WriteLine("Hello");
		}
	}
	static class Food // 創建靜態類別，讓此 類別 無法創造 物件
	{
		public static void SayHi()
		{
			Console.WriteLine("Hello");
		}
	}
}