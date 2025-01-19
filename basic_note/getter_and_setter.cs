// getter、setter
// 用以限制屬性之存取

// 主程式檔案
using ConsoleApp1;
using System;

Video video1 = new Video("真的棒", "小白", "哈哈");
Video video2 = new Video("很棒", "小黑", "娛樂");

video.Type = "教育";
// 執行set {...}

// Console.WriteLine(video1.type); // 會出錯，因為type是private
Console.WriteLine(video1.Type); // Type是public方法，可在類別外使用
// 執行get {return type;}
// 印出 教育

//---------不同檔案分隔線----------

// Video.cs檔

namespace ConsoleApp1
{
	class Video
	{
		public string title;
		public string author;
		// 限制影片類型為以下4種：教育、娛樂、音樂、其他
		private string type;
		// public 指該屬性可在任何地方被存取
		// private 限制該屬性只能在Video類別中被存取
		// 在video類別外的地方想要存取type屬性，要經過public方法Type
		// 而Type方法中限定屬性type只能被寫入4種值，其他的值都當成「其他」
		
		public Video(string title, string author, string type)
		{
			this.title = title;
			this.author = author;
			Type = type;
		}
		
		public string Type // Type為type屬性的對外代理人，存取type或設定type的值都要透過Type（其他小寫名字也可，首字母沒有一定要大寫）
		{
			get {return type;}
			set {
				if(value=="教育" || value=="娛樂" || value=="音樂" || value=="其他")
				{
					type = value;
				}
				else
				{
					type = "其他";
				}
			}
		}
	}

}