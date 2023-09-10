#include<stdio.h>
void main()
{
	int row,col,k=1;
	for(row=1;row<=3;row++)
	{
		for(col=1;col<=row;col++)
		{
			printf("%d ",k++);
		}
		printf("\n");
	}
}
//1.Start
//2.Declare i row,col,k++
//3.Check for row=1;row<=3;row++. then 
//4.Check for col=1;col<=row;col++. then
//  4.1 printf"k"
//4 Stop
