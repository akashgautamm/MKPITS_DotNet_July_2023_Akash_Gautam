#include<stdio.h>
void table(int num,int i)
{
	for(i=1;i<=10;i++)
	{
		printf("%d X %d = %d\n",num,i,num*i);
	}
}
void main()
{
	int num,i;
	printf("Enter table num :");
	scanf("%d",&num);
	table(num,i);
}

