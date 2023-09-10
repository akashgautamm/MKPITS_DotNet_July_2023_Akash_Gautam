#include<stdio.h>
void main()
{
	int i,num,sum=0;
	printf("Enter no :");
	scanf("%d",&num);
	printf("odd no from 1 to %d are : \n",num);
	for(i=1;i<=num;i++)
	{
		if(i%2!=0)
		{
		
	    printf("%d\n",i);
		sum=sum+i;
	    }
	}
	printf("sum of all odd natural numbers %d is %d\n",num,sum);
	
}
//1.Start
//2.Declare i,num,sum=0
//3.Accept num from user
//3.Check with for loop i=1;i<num;i++ then
//4.Check with if loop (i%2!=0) so
//  4.1 sum=sum+i
//  4.2 printf"i"
//  4.3 print("num,sum")
//5.Stop
