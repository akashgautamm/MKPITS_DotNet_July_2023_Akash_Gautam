#include<stdio.h>
void main()
{
	int i;
	int sum=0;
	int mark[3]={90,80,90};
	for(i=0;i<3;i++)
	{
		printf("\nMarks = %d",mark[i]);
		sum=sum+mark[i];
	}
	printf("\nTotal marks = %d",sum);
} 
//1.Start
//2.Declare int i,mark[5],sum=0
//3.Check for i=0;i<5;i++, then
//  3.1 print"mark[i]
//4 3.2 using for sum=sum+mark[i]
//5.print"sum"
//6.Stop
