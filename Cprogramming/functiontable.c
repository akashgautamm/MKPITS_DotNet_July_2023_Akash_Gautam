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
//1.Start
//2.Define the function "table"
//  2.1 Accept num,i
//3.Check for i=1;i<=10;i++
//  3.1 Accept num,i
//  3.2 Call function table num,i
//4.Stop

