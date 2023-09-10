#include<stdio.h>
void main()
{
	int counter=2;
	int rem=0;
	int num;
	printf("Enter num :");
	scanf("%d",&num);
	while(counter<num)
	{
		rem=num%counter;
	if(rem==0)
	{
		printf("It is a not prime num");
		break;
	}
	counter=counter+1;
	if(num==counter)
	{
		printf("It is a prime num");
	}
	}
}

//1.Start
//2.Declare counter=2,rem=0,num
//3.Accept num
//4.Check counter<num then
//  4.1 rem=num%counter
//5.If rem==0 ,then
//  5.1 printf " it is a not prime num"
//  5.2 counter=counter+1
//6.If num==counter ,then
//  6.1 printf "it is a prime no"
//7.Stop
