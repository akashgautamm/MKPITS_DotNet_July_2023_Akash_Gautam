#include<stdio.h>
void main()
{
	int row,col;
	for(row=1;row<=5;row++)
	{
		for(col=1;col<=row;col++)
		{
			printf("* ");
		}
		printf("\n");
	}
}
//1.Start
//2.Declare i row,col
//3.Check for row=1;row<=5;row++. then 
//4.Check for col=1;col<=row;col++. then
//  4.1 printf"*"
//4 Stop
