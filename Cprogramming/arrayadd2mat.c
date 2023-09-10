//wap multipication of two matrices
#include<stdio.h>
void main()
{
	int arr1[2][2]={{1,2},{3,4}};
	int arr2[2][2]={{5,6},{7,8}};
	int arr3[2][2];
	int row,col;
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			arr3[row][col]=arr1[row][col]+arr2[row][col];
		}
	}
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			printf("%d ",arr3[row][col]);
		}
		printf("\n");
	}
}
//1.Start
//2.Declare arr[3][3]intialize also int row,col
//3.Check for row=0;row<2;row++
//  3.1 arr3[row][col]=arr2[row][col]+arr1[row][col]
//4.Check for row=0;row<2;row++
//  4.1 Check for col=0;col<2;col++
//  4.2 print "arr[row][col]
//5.Stop
