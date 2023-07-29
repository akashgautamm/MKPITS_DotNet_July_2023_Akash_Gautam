#include<stdio.h>
void sayhello()
	{
		printf("HELLO\n");
	}
void main()
{
	printf("Calling function\n");
	sayhello();
	printf("Back in function\n");
	sayhello();
	
	printf("\nBYE");
}
