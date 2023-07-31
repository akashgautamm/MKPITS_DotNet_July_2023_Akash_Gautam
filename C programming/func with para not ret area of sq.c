//function with parameter and not return value
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
//1.Start
//2.Create a function with name square 
//  2.1 using formula result=num*num
//  2.2 print"result"
//3.Create a function with name main
//  3.1 Accept num,result=0
//  3.2 Find a num with user
//  3.3 Call the function square (num)
//  3.4 printf"Bye"
//4.Stop
