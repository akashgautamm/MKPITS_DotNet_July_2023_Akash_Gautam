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
