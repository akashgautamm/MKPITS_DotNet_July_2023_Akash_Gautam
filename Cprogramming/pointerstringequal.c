#include<stdio.h>
void main()
{
	char n1[20];
	char n2[20];
	char *ptr1;
	char *ptr2;
	printf("Enter name 1: ");
	gets(n1);
	printf("Enter name 2: ");
	gets(n2);
	ptr1=n1;
	ptr2=n2;
	while(*ptr1!='\0' || *ptr2!='\0')
	{
		if(*ptr1==*ptr2)
		{
			printf("String is equal");
			break;
		}
		else;
		{
			printf("String is not equal");
			break;
		}
	}
}
//1.Start
//2.Declare char n1,n2,*ptr1,*ptr2;
//3.Equal value ptr1=n1,ptr2=n2;
//4.Check while *ptr!='\0' or *ptr2!=0
//5.Check if *ptr1==*ptr2
//  5.1 print "string is equal" otherwise
//  5,2 else print"string is not equal"
//6.Stop
      
