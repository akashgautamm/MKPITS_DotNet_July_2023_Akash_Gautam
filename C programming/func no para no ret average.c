//function: not parameter and not return value of average

#include<stdio.h>
void average()
{
	int n1,n2,n3,n4,n5;
	printf("Enter 5 num :");
	scanf("%d%d%d%d%d",&n1,&n2,&n3,&n4,&n5);
	int add=n1+n2+n3+n4+n5;
	printf("Addition is = %d\n",add);
	int avg=add/5;
	printf("Average is = %d\n",avg);
}
void main()
{
	int n1,n2,n3,n4,n5,add,avg;
	average(n1,n2,n3,n4,n5,avg,add);
}
//1.Start
//2.Create a function with name average
//  2.1 Accept n1,n2,n3,n4,n5
//  2.2 using formula add=n1+n2+n3+n4+n5
//  2.3 print "add" 
//  2.4 using formula avg=add/5
//  2.5 print"avg"
//3.Create a function with name main
//  3.1 Accept n1,n2,n3,n4,n5,add,avg
//  3.2 Call the function average (n1,n2,n3,n4,n5,avg,add)
//4.Stop
