//function without parameter and return value
#include<stdio.h>
int oddeven()
{
	int rem=0,num;
	printf("Enter num :");
	scanf("%d",&num);
	if(num%2==0)
	{
		printf("It is a even num");
	}
	else
	{
		printf("It is a odd num");
	}
	return 0;
}
void main()
{
	int rem=0,num;
	oddeven(num,rem);
}
//1.Start
//2.Create a function with name oddeven
//  2.1 Accept num,rem=0
//  2.2 Check with if (num%2==0)
//  2.3 print "even num" otherwise else "odd num"
//3.Create a function with name main
//  3.1 Accept num,rem=0
//  3.2 Call the function oddeven (num,rem)
//4.Stop
