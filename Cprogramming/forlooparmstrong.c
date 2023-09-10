#include<stdio.h>
void main()
{
	int num,rem,sum=0,i;
	printf("Enter no");
	scanf("%d",&num);
	
	for(i=num;num!=0;num=num/10)
	{
		rem=num%10;
		sum=sum +(rem*rem*rem);
	}
	if(sum==i)
	{
		printf("%d is armstrong number\n",i);
	}
	else
	{
		printf("%d is not armstrong number\n",i);
	}
}

//1.Start
//2.Declare i,num,sum=0,rem
//3.Accept num from user
//3.Check with for loop i=num;num!=0;num=num/10 then
//  3.1.rem=num%10;
//  3.2.sum=sum+(rem*rem*rem);
//4.Check with if loop (sum==i) so
//  4.1 printf it is armstrong num",i
//  4.2 printf "it is not armstrong num",i
//5.Stop
