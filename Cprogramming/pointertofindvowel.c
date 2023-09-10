#include<stdio.h>
int main()
{
	int count=0;
	char name[20];
	char *ptr;
	printf("Enter name :");
    gets(name);
    ptr=name;
	while(*ptr!='\0')
	{
		if(*ptr=='a' || *ptr=='e' || *ptr=='i' || *ptr=='o' || *ptr=='u')
		{
			count=count+1;
		}
		ptr++;
		
	}
	printf("Number of vowels in string = %d",count);	
}
//1.Start
//2.Declare char name=20,*ptr,int counter=0
//3.Accept name
//4.ptr=name
//5.Check while *ptr1!='\0'
//  ptr++
//6.Check if*ptr==a or *ptr==e or *ptr==i or *ptr==o or *ptr==u
//  counter=counter+1
//7.print"counter"
//8.Stop      
