//wap  to check whether matrices are equal or not equal.....
#include<stdio.h>
void main()
{
	int row,col,i;
	int arr1[2][2];
	int arr2[2][2];
	printf("Enter first matrices :");
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			scanf("%d",&arr1[row][col]);
		}
	}
	printf("Enter second matrices");
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			scanf("%d",&arr2[row][col]);
		}
	}
	i=1;
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
		  if(arr1[row][col]!=arr2[row][col])
		  i=0;
		  break;
		}
	}
	if(i==1)
	{
		printf("\nMatrices are equal");
		
	}
	else
	{
		printf("\nMatrices are not equal");
	}
}
//1.Start
//2.Declare arr1[2][2]arr[2][2]intialize also int row,col,i
//3.Check for row=0;row<2;row++
//  3.1 for col=0;col<2;col++
//  3.1 Accept first matrices from user
//4.Check for row=0;row<2;row++
//  4.1 for col=0;col<2;col++
//  4.1 Accept second matrices from user
//5.Check for row=0;row<2;row++
//  5.1 forcol=0;col<2;col++
//  5.2 check if arr1[row][col]=arr2[col][row];
//6.Check if i==1
//  6.1 printf"matrices are equal" else not equal
//7.Stop
	
	
