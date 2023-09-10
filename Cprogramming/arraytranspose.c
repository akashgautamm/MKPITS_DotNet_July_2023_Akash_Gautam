//wap to find a transpose of even num....
#include<stdio.h>
void main()
{
	int row,col;
	int arr1[2][2];
	int arr2[2][2];
	printf("Enter matrices :");
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			scanf("%d",&arr1[row][col]);
		}
	}
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			arr2[row][col]=arr1[col][row];
		}
	}
	printf("Transpose of matrices\n");
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			printf("%d\t",arr2[row][col]);
		}
		printf("\n");
	}
}
//1.Start
//2.Declare arr[2][2]intialize also int row,col
//3.Check for row=0;row<2;row++
//  3.1 for col=0;col<2;col++
//  3.1 Accept num from user
//4.Check for row=0;row<2;row++
//  4.1 forcol=0;col<2;col++
//  4.2 arr2[row][col]=arr1[col][row];
//5.Check for row=0;row<2;row++
//  5.1for col=0;col<2;col++
//  5.2 print"arr[row][col]
//5.Stop
