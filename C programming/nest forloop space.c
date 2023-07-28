#include<stdio.h>
void main()
{
	int row,col,space,k;
	space=row+3-1;
	for(row=1;row<=3;row++)
	{
		for(k=space;k>=1;k--)
		{
			printf("  ");
		}
		for(col=1;col<=row;col++)
		{
			printf("%d  ",col);
		}
		space--;
		printf("\n");
	}
}
//1.Start
//2.Declare space,row,col,k
//3.space=row+3-1
//4.Check for row=1;row<=3;row++. then
//5.Check for k=space;k>=1;k--
//  5.1print"  " 
//6.Check for col=1;col<=row;col++. then
//  6.1 print"col"
//4 Stop


