#include<stdio.h>
void main()
{
	int num,i=1;
	printf("Enter num :");
	scanf("%d",&num);
	table:
	printf("%d X %d =%d\n",num,i,num*i);
	i++;
	if(i<=10)
	{
	goto table;
	}
}
//1.Start
//2.Aceept num,i=1
//3.Create table:
//  3.1 printf num,i,num*i
//4. Check if i<=10
//  4.1 call statement goto "table"
//5.Stop
