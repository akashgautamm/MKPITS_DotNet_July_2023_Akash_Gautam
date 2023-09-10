#include<stdio.h>
void addition(int n1,int n2,int *result)
{
	*result=n1+n2;
}
void main()
{
	int n1,n2,result;
	printf("Enter two num :");
	scanf("%d%d",&n1,&n2);
	addition(n1,n2,&result);
	printf("Result is = %d",result);
	
	
}
//1.Start
//2.Create a function with name addition
//  2.1 using formula *rsult=n1+n2
//3.Create a function with name main
//  3.1 Accept result,n1,n2
//  3.2 Find a num with user
//  3.3 Call the function calculate (result,n1,n2)
//  3.4 print"result"
//4.Stop
