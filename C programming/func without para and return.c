#include<stdio.h>
int square()
{
	int num;
	printf("Enter num");
	scanf("%d",&num);
	int result=num*num;
	return result;
}
void main()
{
	char ch='y';
	do
	{
		int result;
		result=square();
		printf("Area of square = %d",result);
		printf("Do you want continue,Press y");
		fflush(stdin);
		scanf("%c",&ch);
	}
	while(ch=='y');
}
