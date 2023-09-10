
#include<stdio.h>
int square(int num)
{
	int result=num*num;
	return result;
}
void main()
{
	char ch='y';
	do
	{
		int num,result=0;
		printf("Enter num");
		scanf("%d",&num);
		result=square(num);
		printf("Area of square = %d\n",result);
		printf("Do you want continue,Press y\n");
		fflush (stdin);
		scanf("%c",&ch);
	}
	while(ch=='y');
}
