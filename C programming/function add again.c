#include<stdio.h>
void addition(int n1,int n2)
{
	int result=n1+n2;
	printf("sum of two num is = %d",result);
}
void main()
{
	char ch='y';
    do
    {
    	int n1,n2;
    	printf("Enter 2 num :");
    	scanf("%d%d",&n1,&n2);
    	addition(n1,n2);
    	printf("\nDo you want continue,Press y ");
    	fflush(stdin);
    	scanf("%c",&ch);
    }
    while(ch=='y');
}
//1.Start
//2.Define the function "addition"
//3.Accept n1,n2
//  3.1 using formula result=n1+n2
//  3.2 print"result"
//4.Go to main function
//  4.1 Accept char ch='y'
//  4.2 Then n1 and n2 give with user
//  4.3 Call the function "addition ni,n2"
//  4.4 Print "do you want continue press y"
//5.Check while(ch=='y'
//6.Stop

