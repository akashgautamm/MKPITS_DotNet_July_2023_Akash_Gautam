#include<stdio.h>
void square()
{
	int num;
	printf("Enter num :");
	scanf("%d",&num);
	int result=num*num;
	printf("result is %d",result);
}
void main()
{
	int result=0,num;
	square(result,num);
}
