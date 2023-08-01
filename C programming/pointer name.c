#include<stdio.h>
#include<string.h>
void main()
{
	char name[20];
	char *ptr;
	printf("Enter name :");
	gets (name);
	ptr=name;
	while(*ptr!='\0')
	{
		printf("%c",*ptr);
		*ptr++;
	}
}
//1.Start
//2.Declare char name=20,*ptr
//3.Accept name
//4.ptr=name
//5.Check while *ptr1!='\0'
//  print"ptr"
//  ptr++
//6.Stop      
