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
