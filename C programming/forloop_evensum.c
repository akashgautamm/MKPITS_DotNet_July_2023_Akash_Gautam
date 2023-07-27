#include<stdio.h>
void main()
{
	int i;
	int sum=0;
	int num;
	printf("Enter no :");
	scanf("%d",&num);
	for(i=2;i<=num;i++)
	{
		if(i%2==0)
		{
			printf("%d\n",i);
			sum=sum+i;
		}
	}
	printf("Sum of all even natural number 2 to %d is %d\n",num,sum);
	
}
//1.Start
//2.Declare i,num,sum=0
//3.Accept num from user
//3.Check with for loop i=1;i<num;i++ then
//4.Check with while loop (i<=num) so
//  4.1 sum=sum+i*i
//  4.2 printf"num,sum"
//5.Stop
