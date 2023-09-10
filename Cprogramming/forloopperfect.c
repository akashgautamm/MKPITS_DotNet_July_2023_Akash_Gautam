#include<stdio.h>
void main()
{
	int num,i,sum=0;
	printf("Enter num :");
	scanf("%d",&num);
	printf("number of %d are :\n",num);
	for(i=1;i<num;i++)
	{
		if(num%i==0)
		{
			printf("%d\n",i);
			sum=sum+i;
		}
	}
	if(sum==num)
	{
		printf("%d is a perfect num\n",num);
	}
	else
	{
		printf("%d is not perfect num\n",num);
	}
}
//1.Start
//2.Declare i,num,sum=0
//3.Accept num from user
//3.Check with for loop i=1;i<num;i++ then
//4.Check with if num%i==0
//  4.1 sum=sum+i
//  4.2 printf"i"
//5.Check  if sum==num
//  5.1 printf"it is a perfect num"
//  5.2 else, printf"It is not perfect num"
//6.Stop
