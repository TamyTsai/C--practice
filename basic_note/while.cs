// while迴圈

int num = 1;
while (num <= 5)
{
	System.Console.WriteLine(num);
	num = num + 1;
	// num += 1;
	// num ++;
}
/*
印出 
1
2
3
4
5 
*/

int num2 = 6;
while (num2 <= 5)
{
	System.Console.WriteLine(num);
	num = num + 1;
}
/*
不會印出東西（一開始就不符合迴圈條件，所以不會執行迴圈內程式碼） 
*/

int num3 = 6;
do
{
	System.Console.WriteLine(num);
	num++;
}
while (num <= 5);
/*
印出6（先執行大刮號裡的程式碼，再判斷條件是否成立，是否重複進行程式碼）
*/
