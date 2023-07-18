#include <stdio.h>
int main()
{
	int num;
	printf("Enter num:");
	scanf("%d",&num);
	if(num<0)
	{
		printf("num is negative");
	}
	else if(num==0)
	{
		printf("num is equal to zero");
	}
	else
	{
		printf("num is positive");
	}
	return 0;

}
//1.Start
//2.Accept num,int num
//3.Check num is less than zero
//  3.1) printf"num is negative
//  3.2) Go to step 6
//4.Check num is equal to zero
//  4.1)printf"num is equal to zero
//  4.3)Go to step 6
//5.printf "num is greater"
//6. Stop
