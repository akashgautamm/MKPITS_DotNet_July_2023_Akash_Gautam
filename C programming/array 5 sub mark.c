#include<stdio.h>
void main()
{
	int i;
	int sum=0;
	int marks[5];
	for(i=0;i<5;i++)
	{
		printf("Enter 5 subject marks :");
		scanf("%d",&marks[i]);
	}
	for(i=0;i<5;i++)
	{
		printf("\n Marks = %d",marks[i]);
		sum=sum+marks[i];
	}
	printf("\nTotal marks = %d",sum);
}
//1.Start
//2.Declare int i,mark[5],sum=0
//3.Check for i=0;i<5;i++, then
//  3.1 read 5 subject marks
//3.Check for i=0;i<5;i++, then
//  3.1 print"mark[i]
//4 3.2 using for sum=sum+mark[i]
//5.print"sum"
//6.Stop
