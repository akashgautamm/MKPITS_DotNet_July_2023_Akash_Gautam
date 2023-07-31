//function with parameter and not return value
#include<stdio.h>
void oddeven(int num,int rem)
{
	if(num%2==0)
	{
		printf("It is a even num");
	}
	else
	{
		printf("It is a odd num");
	}
}
void main()
{
	int rem=0,num;
	printf("Enter num :");
	scanf("%d",&num);
	oddeven(num,rem);
}
//1.Start
//2.Create a function with name oddeven
//  2.1 Check with if (num%2==0)
//  2.2 print "even num" otherwise else "odd num"
//3.Create a function with name main
//  3.1 Accept num,rem=0
//  3.2 Call the function oddeven (num,rem)
//4.Stop
