#include<stdio.h>
void addition(int n1,int n2)
{
	int result=n1+n2;
	printf("sum of two num is = %d",result);
}
void main()
{
	char ch='y';
    do
    {
    	int n1,n2;
    	printf("Enter 2 num :");
    	scanf("%d%d",&n1,&n2);
    	addition(n1,n2);
    	printf("\nDo you want continue,Press y ");
    	fflush(stdin);
    	scanf("%c",&ch);
    }
    while(ch=='y');
}
