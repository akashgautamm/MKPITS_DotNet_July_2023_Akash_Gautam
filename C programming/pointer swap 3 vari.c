#include<stdio.h>
void main()
{
	int temp;
	int n1=10;
	int n2=20;
	int *p1=&n1;
	int *p2=&n2;
	printf("before swap *p1=%d,*p2=%d\n",*p1,*p2);
    temp=*p1;
	*p1=*p2;
	*p2=temp;
	printf("After swap *p1=%d,*p2=%d",*p1,*p2);
		
}
//1.Start
//2.Declare temp.n1=10,n2=20,*ptr1=&n1,*ptr2=&n2;
//3.print before swap "*ptr1,*ptr2"
//4.using formula
//  temp=*ptr1
//  *ptr1=*ptr2
//  *ptr2=temp
//5.print after swap "*ptr1,*ptr2
//6.Stop
      
