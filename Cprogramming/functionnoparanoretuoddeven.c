//function with no parameter and no return 
#include<stdio.h>
void oddeven()
{
	int num,rem=0;
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
}
void main()
{
	int num,rem=0;
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
