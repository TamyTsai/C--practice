// 猜數字遊戲

int answer = 2;
int guess; // 先創建值，裡面先不放內容
int guess_time = 0;
int limit = 3;
bool win = false;

do
{
	System.Console.Write("請輸入猜測：");
	guess = System.Convert.ToInt32(System.Console.ReadLine());
	
	guess_time ++;
	
	if (guess < answer)
	{
		System.Console.WriteLine("再大一點");
	}
	else if (guess > answer)
	{
		System.Console.WriteLine("再小一點");
	}
	else
	{
		System.Console.WriteLine("猜中了");
		win = true;
	}
}
while (guess != answer && guess_time <= limit);

// 跳出迴圈有兩種狀況：1.猜對了 2.猜測次數超過限制
// 而猜對了的時候，win被改成true，所以不會執行以下程式碼
if(!win)
{
		System.Console.WriteLine("抱歉，你輸了");
}



/*
do
{
	System.Console.Write("請輸入猜測：");
	guess = System.Convert.ToInt32(System.Console.ReadLine());
	
	if (guess < answer)
	{
		System.Console.WriteLine("再大一點");
	}
	else if (guess > answer)
	{
		System.Console.WriteLine("再小一點");
	}
	else
	{
		System.Console.WriteLine("猜中了");
	}
	guess_time ++;
	if (guess_time > limit && guess != answer )
	{
		System.Console.WriteLine("猜測錯誤達3次，你輸了");
	}
}
while (guess != answer && guess_time <= limit);
*/