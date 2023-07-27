#include<stdio.h>
void main()
{
	int num,square;
	int sum=0;
	int i=1;
	printf("Enter num :");
	scanf("%d",&num);
	printf("square from 1 to %d are:\n",num);
	for(i=1;i<=num;i++)
	{
		square=i*i;
		printf("%d\n",square);
		sum=sum+square;
	}
	printf("\n sum of square natural no upto %d terms %d",num,sum);
}

//1.Start
//2.Declare i,num,sum=0,square
//3.Accept num from user
//3.Check with for loop (i=1;i<=num;i++ then
//  3.1.square=i*i
//  3.2.printf"square"
//  3.3 sum=sum+square
//4.printf "num,sum"
//5.Stop
