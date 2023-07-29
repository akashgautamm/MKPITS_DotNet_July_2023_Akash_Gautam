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


