#include<stdio.h>
int addition()
{
	int n1,n2;
	printf("Enter two num :");
	scanf("%d%d",&n1,&n2);
	int result=n1+n2;
	return result;
}
void main()
{
	char ch='y';
	do
	{
		int result;
		result=addition();
		printf("Result is %d\n",result);
		printf("Do you want continue, Press y\n");
		fflush(stdin);
		scanf("%c",&ch);
	}
	while(ch=='y');
}
