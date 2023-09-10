//function without no parameter and no return value
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
//1.Start
//2.Create a function with name square
//  2.1 Accept num 
//  2.2 using formula result=num*num
//  2.3 print"result"
//3.Create a function with name main
//  3.3 Call the function square (num,result)
//  3.4 printf"Bye"
//4.Stop
