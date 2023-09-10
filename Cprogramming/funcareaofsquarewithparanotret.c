#include<stdio.h>
void square(int num)
{
	int result=num*num;
	printf("Area is = %d",result);
}
void main()
{
	int num,result=0;
	printf("Area of square :");
	scanf("%d",&num);
	square(num);
	printf("\n Bye");
}
