#include<stdio.h>
void main()
{
	int n1=10;
	int n2=20;
	int *p1=&n1;
	int *p2=&n2;
	printf("Before swap *p1=%d,*p2=%d\n",*p1,*p2);
	*p1=*p1+*p2;
	*p2=*p1-*p2;
	*p1=*p1-*p2;
	printf("After swap *p1=%d,*p2=%d",*p1,*p2);
}
//1.Start
//2.Declare n1=10,n2=20,*p1=&n1,*p2=&n2;
//3.print before swap "*p1,*p2"
//4.using formula
//  *p1=*p1+*p2;
//	*p2=*p1-*p2;
//	*p1=*p1-*p2;
//5.print after swap "*p1,*p2
//6.Stop
      
