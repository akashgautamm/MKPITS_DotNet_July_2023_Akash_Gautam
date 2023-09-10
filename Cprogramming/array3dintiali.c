#include<stdio.h>
void main()
{
	int arr[3][3];
	int row,col;
	for(row=0;row<3;row++)
	{
		for(col=0;col<3;col++)
		{
			printf("Enter num :");
			scanf("%d",&arr[row][col]);
		}
	}
	for(row=0;row<3;row++)
	{
		for(col=0;col<3;col++)
		{
			printf("arr[%d][%d]=%d\n",row,col,arr[row][col]);
		}
	}
}
//1.Start
//2.Declare arr[3][3]intialize also int row,col
//3.Check for row=0;row<2;row++
//  3.1 Check for col=0;col<2;col++
//  3.1 Accept num
//4.Check for row=0;row<2;row++
//  4.1 Check for col=0;col<2;col++
//  4.2 print "row,col,arr[row][col]"
//5.Stop
