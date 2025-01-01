// if判斷句

// 1.
// 如果 我肚子餓
//     我就去吃飯

bool hungry = true;

if(hungry)
{
	System.Console.WriteLine("我就去吃飯");
}

// 2.
// 如果 今天有下雨
//   我就開車去上班
// 否則
//   我就走路去上班

bool rainy = true;

if(rainy)
{
	System.Console.WriteLine("我就開車去上班");
}
else
{
	System.Console.WriteLine("我就走路去上班");
}

/*
3.
如果 你考100分
	我給你1000元
或是如果 你考80分以上
	我給你500元
或是如果 你考60分以上
	我給你100元
否則
	你給我300元
*/

int score = 100;

if (score == 100)
{
	System.Console.WriteLine("我給你1000元");
}
else if (score >= 80)
{
  System.Console.WriteLine("我給你500元");
}
else if (score >= 60)
{
  System.Console.WriteLine("我給你100元");
}
else
{
  System.Console.WriteLine("你給我300元");
}

/*
4.
如果 你考100分 且 今天有下雨
	我給你1000元
否則
	你給我100元
*/

int score2 = 100;
bool rainy2 = true;

if(score2 == 100 && rainy2)
{
	System.Console.WriteLine("我給你1000元");
}
else
{
	System.Console.WriteLine("你給我100元");
}

/*
5.
如果 你考100分 或 今天有下雨
	我給你1000元
否則
	你給我100元
*/

if(score2 == 100 || rainy2)
{
	System.Console.WriteLine("我給你1000元");
}
else
{
	System.Console.WriteLine("你給我100元");
}

/*
6.
如果 你沒有考100分 或 今天沒有下雨
	我給你1000元
否則
	你給我100元
*/

if(score2 != 100 || !rainy2)
{
	System.Console.WriteLine("我給你1000元");
}
else
{
	System.Console.WriteLine("你給我100元");
}
