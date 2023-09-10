//function without parameter and return value
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
//1.Start
//2.Create a function with name square 
//  2.1 Accept num
//  2.2 using formula result=num*num
//  2.3 print"result"
//3.Create a function with name main
//  3.1 Accept result=0,char ch='y'
//  3.2 call function with return result=square()
//  3.3 print"result"
//  3.4 printf"do you want again ,press y"
//4 check for while(ch=='y')
//4.Stop
