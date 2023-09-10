#include<stdio.h>
void main()
{
	int i;
	int sum=0;
	int marks[3];
	marks[0]=99;
	marks[1]=88;
	marks[2]=87;
	for(i=0;i<3;i++)
	{
		printf("\nMarks %d ",marks[i]);
		sum=sum+marks[i];
	}
	printf("\nTotal marks is = %d",sum);
}
//1.Start
//2.Declare int i,mark[5],sum=0
//3.Check for i=0;i<5;i++, then
//  3.1 print"mark[i]
//4 3.2 using for sum=sum+mark[i]
//5.print"sum"
//6.Stop
 
