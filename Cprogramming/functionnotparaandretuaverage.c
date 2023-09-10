//function not parameter and return value
#include<stdio.h>
int average()
{
	float n1,n2,n3,n4,n5,add;
	float avg;
	printf("Enter 5 num :");
	scanf("%f%f%f%f%f",&n1,&n2,&n3,&n4,&n5);
    add=n1+n2+n3+n4+n5;
	printf("Addition is = %f\n",add);
	avg=add/5;
	return avg;
}
void main()
{
	float avg;
	avg=average();
	printf("Average is = %f\n",avg);
}
//1.Start
//2.Create a function with name average
//  2.1 Accept n1,n2,n3,n4,n5
//  2.2 using formula add=n1+n2+n3+n4+n5
//  2.3 print "add" 
//  2.4 using formula avg=add/5
//3.Create a function with name main
//  3.1 Accept n1,n2,n3,n4,n5,add,avg
//  3.2 Call the function avg=average ()
//  3.3 printf"avg"
//4.Stop
