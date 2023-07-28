#include<stdio.h>
void main ()
{
	int space,k,col,row;
	space=row+6-1;
	for(row=1;row<=7;row++)
	{
		for(k=space;k>=1;k--)
		{
			printf("  ");
		}
		for(col=1;col<=row;col++)
		if(row%2!=0)
		{
			printf("*  ");
		}
		space--;
		printf("\n");
	}
	
}
//1.Start
//2.Declare space,row,col,k
//3.Check for row=1;row<=7;row++. then
//4.Check for k=space;k>=1;k--
//  4.1print"  " 
//5.Check for col=1;col<=row;col++. then
//  4.1 print"*"
//4 Stop

