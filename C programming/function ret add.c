#include<stdio.h>
int addition(int n1,int n2)
{
	int result=n1+n2;
	return result;
}
void main()
{
	char ch='y';
	do
	{
		int n1,n2,result;
		printf("Enter two num :");
		scanf("%d%d",&n1,&n2);
		result=addition(n1,n2);
		printf("Result is %d",result);
		printf("Do you want continue, press y");
		fflush(stdin);
		scanf("%c",&ch);
	}
	while(ch=='y');
}
