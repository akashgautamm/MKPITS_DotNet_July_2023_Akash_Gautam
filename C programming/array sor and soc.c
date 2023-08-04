//wap to sum of row and sum of column.....
#include<stdio.h>
void main()
{
	int row,col;
	int arr[2][2];
	int sor,soc;
	printf("Enter matrices :");
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			scanf("%d",&arr[row][col]);
		}
	}
	for(row=0;row<2;row++)
	{
		sor=soc=0;
		for(col=0;col<2;col++)
		{
			sor=sor+arr[row][col];
			soc=soc+arr[col][row];
		}
		printf("sum of row = %d\n",sor);
		printf("sum of col = %d\n",soc);
	}
}
//1.Start
//2.Declare arr[2][2]intialize also int row,col,sor,soc
//3.Check for row=0;row<2;row++
//  3.1 Accept num from user
//4.Check for row=0;row<2;row++
//  4.1 sor=soc=0
//5 Check for col=0;col<2;col++
//  5.1 sor=sor+arr[row][col];
//  5.2 soc=soc+arr[col][row];
//  5.3 print"sor,soc"
//5.Stop
