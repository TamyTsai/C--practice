// static attribute靜態屬性

// 主程式檔案
using ConsoleApp1;
using System;

Video video1 = new Video("真的棒", "小白", "教育");
Video video2 = new Video("很棒", "小黑", "娛樂");

Console.WriteLine(video1.type);
Console.WriteLine(video2.type);
// Console.WriteLine(video1.video_count); // 在 物件 上使用 靜態屬性 會出錯
Console.WriteLine(Video.video_count);
// 一般屬性 在 「物件」 上 使用
// 靜態屬性 在 「類別」 上 使用
Console.WriteLine(video1.getVideoCount());
// 用 公開方法 來存取 靜態屬性
// 印出2


//---------不同檔案分隔線----------

// Video.cs檔

namespace ConsoleApp1 
{
	class Video
	{
		public string title; // title為物件的屬性，static attribute為類別的屬性
		public string author;
		public string type;
		public static int video_count = 0; // 記錄以此類別建構了幾次物件
		
		public Video(string title, string author, string type)
		{
			this.title = title;
			this.author = author;
			this.type = type;
			video_count++;
		}
		
		public int getVideoCount() //透過寫這個方法 讓video「物件」也可以讀取 video_count這個靜態屬性
		{
			return video_count;
		}
	}
}