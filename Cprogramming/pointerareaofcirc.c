#include<stdio.h>
void calculate(int r,float *a,float *c)
{
	*a=3.14f*r*r;
	*c=2*3.14*r;
}
void main()
{
	float radius,area,circ;
	printf("Enter radius :");
	scanf("%f",&radius);
	calculate(radius,&area,&circ);
	printf("\nArea of circle = %f",area);
	printf("\nCircumference of circle  = %f",circ);
}
//1.Start
//2.Create a function with name calculate
//  2.1 using formula *a=3.14f*r*r,*c=2*3.14*r
//3.Create a function with name main
//  3.1 Accept radius,area,circ
//  3.2 Find a radius with user
//  3.3 Call the function calculate (radius,&area,&circ)
//  3.4 print"circ"
//4.Stop
