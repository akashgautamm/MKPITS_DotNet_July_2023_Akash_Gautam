//function with parameter and return value
#include<stdio.h>
int average(float n1,float n2,float n3, float n4, float n5,float add)
{
	float avg=add/5;
	return avg;
}
void main()
{
	float n1,n2,n3,n4,n5,add,avg;
	printf("Enter  5 num :");
	scanf("%f%f%f%f%f",&n1,&n2,&n3,&n4,&n5);
    add=n1+n2+n3+n4+n5;
	printf("Addition is = %f\n",add);
    avg=average(n1,n2,n3,n4,n5,add);
	printf("Average is = %f\n",avg);	
}
//1.Start
//2.Create a function with name average
//  2.1 using formula avg=add/5
//  2.2 print"avg"
//3.Create a function with name main
//  3.1 Accept n1,n2,n3,n4,n5,add,avg
//  3.2 Accept n1,n2,n3,n4,n5
//  2.2 using formula add=n1+n2+n3+n4+n5
//  2.3 print "add" 
//  3.2 Call the function avg=average (n1,n2,n3,n4,n5,add)
//4.Stop
