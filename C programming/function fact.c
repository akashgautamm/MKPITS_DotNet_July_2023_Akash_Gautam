#include<stdio.h>
void factorial(int num,int fact)
{
	while(num>0)
	{
		fact=fact*num;
	    num=num-1;
    }
    printf("Factorial is %d",fact);
	
}
void main()
{
	int fact=1,num;
	printf("Enter num :");
	scanf("%d",&num);
	factorial(num,fact);
}
//1.Start
//2.Define the function "factorial"
//  2.1 Accept num,fact
//3.Check for while(num>0)
//  3.1 using formula fact=fact*num ,num=num-1
//  3.2 print "factorial"
//4.Go to main function
//  4.1 Aceept fact=1,num
//  4.2 Call function -factorial(num,fact)
//5.Stop

