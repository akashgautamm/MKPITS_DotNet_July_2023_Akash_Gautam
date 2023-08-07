#include<stdio.h>
#include<string.h>
struct worker
{
	int sum,pay1,pay2;
	char w1[20];
	char w2[20];
	
};
void main()
{
	struct worker wor[2];
	int sum;
	int counter;
	for(counter=0;counter<1;counter++)
	{
		printf("Enter worker and Payment :");
		scanf("%s%s%d%d",&wor[counter].w1,&wor[counter].w2,&wor[counter].pay1,&wor[counter].pay2);
		sum=wor[counter].pay1+wor[counter].pay2;
		for(counter=0;counter<1;counter++)
		{
			printf("\nWorker =%s\t",wor[counter].w1);
			printf("Worker =%s\t",wor[counter].w2);
			printf("\nPayment =%d\t",wor[counter].pay1);
			printf("Payment =%d\t",wor[counter].pay2);
		}
	}
	printf("\ntotal worker payment is =%d",sum);
	

}
//1.Start
//2.Create struct worker
//3.Declare int sum,pay1,pay2,char w1 and w2
//4.Create void main
//5.Declare counter,sum
//6.Check for loop counter=0 or counter<1
//7.print "worker,payment"from user
//8.formula sum=wor of pay1+wor of pay2
//9.Check for loop counter=0 or counter<1
//10.print "w1,w2,pay1,pay2"
//11.print"sum"

