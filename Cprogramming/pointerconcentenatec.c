#include<stdio.h>
void main()
{
	char name1[20];
	char name2[20];
	char *ptr1;
	char *ptr2;
	printf("Enter name 1 :");
	gets(name1);
	printf("Enter name 2 :");
	gets(name2);
	ptr1=name1;
	while(*ptr1!='\0')
	{
		ptr1++;
	}
	ptr2=name2;
	while(*ptr2!='\0')
	{
		*ptr1=*ptr2;
		ptr1++;
		ptr2++;
	}
	*ptr1='\0';
	printf("concetenate string = %s",name1);
	
}
//1.Start
//2.Declare char n1=10,n2=20,*ptr1,*ptr2
//3.Accept name1,name2 
//4.ptr1=name1
//5.Check while *ptr1!='\0'
//  *ptr1++//  
//6.*ptr2=name2
//7.while *ptr2!='\0'
//  *ptr1=*ptr2
//  ptr1++
//  ptr2++
//8.*ptr='\0'
//  8.1 print "name1"
//9.Stop      
