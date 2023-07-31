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
//1.Start
//2.Define the function "sayhello"
//  2.1 print"hello"
//3.Go to main function
//  3.1 print"calling function"
//  3.2 call function "sayhello"
//  3.3 print"back in function"
//  3.4 call function "sayhello"
//  3.5 print"Bye" 
