#include<stdio.h>
void main()
{
	int counter=0;
	char name[20];
	char *ptr;
	printf("Enter name :");
	gets(name);
	ptr=name;
	while(*ptr!='\0')
	{
		counter=counter+1;
		ptr++;
	}
	printf("length of string is %d",counter);
}
//1.Start
//2.Declare char name=20,*ptr,int counter=0
//3.Accept name
//4.ptr=name
//5.Check while *ptr1!='\0'
//  counter=counter+1
//  ptr++
//6.print"counter"
//7.Stop      
