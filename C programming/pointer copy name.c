#include<stdio.h>
void main()
{
	char name1[20];
	char name2[20];
	char *ptr1;
	char *ptr2;
	printf("Enter name :");
	gets(name1);
	ptr1=name1;
	ptr2=name2;
	while(*ptr1!='\0')
	{
		*ptr2=*ptr1;
		ptr1++;
		ptr2++;
	}
	*ptr2='\0';
	printf("copy name : %s",name2);
	
}
//1.Start
//2.Declare char n1=10,n2=20,*ptr1,*ptr2
//3.Accept name1
//4.ptr1=name1
//  ptr2=name2
//7.Check while *ptr1!='\0'
//  *ptr1=*ptr2
//  ptr1++
//  ptr2++
//8.*ptr='\0'
//  8.1 print "name2"
//9.Stop      
