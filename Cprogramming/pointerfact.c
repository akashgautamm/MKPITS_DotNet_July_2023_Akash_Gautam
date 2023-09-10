#include<stdio.h>
void factorial(int num, int *fact )
{
	while(num>0)
	{
		*fact=*fact*num;
		num=num-1;
	}
}
void main()
{
	int num,fact=1;
	printf("Enter num :");
	scanf("%d",&num);
	factorial(num,&fact);
	printf("Factorial is = %d",fact);
}
//1.Start
//2.Create a function with name factorial
//3.Check while num>0
//  3.1 using formula *fact=*fact-num,num=num-1
//4.Create a function with name main
//  3.1 Accept num,fact=1
//  3.2 Find a num with user
//  3.3 Call the function factorial (num,&fact)
//  3.4 print"fact"
//5.Stop
