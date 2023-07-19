#include <stdio.h>
void main()
{
	int num1,num2,result=0;
	char op;
	printf("Enter 2 num:\n");
	scanf("%d%d",&num1,&num2);
	printf("Enter (+,-,*,/)");
	fflush(stdin);
	scanf("%c",&op);
	switch(op)
	{
		case'+':
			result=num1+num2;
			break;
		case'-':
		    result=num1-num2;
			break;
		case'*':
			result=num1*num2;
			break;
		case'/':
			result=num1/num2;
			break;
		default:
			printf("Invalid op");
			break;
			
	}
	printf("result=%d",result);
}

//1.Start
//2.Accept int num1,num2,result also use char op
//3.If case op+ then
//  3.1 result =num1 +num2
//4.If case op- then
//  4.1 result =num1 -num2
//5.If case op* then
//  5.1 result = num1*num2
//6.If case op/ then
//  6.1 result=num1/num2
//7.If op is not between (+-*/)
//  7.1 printf"invalid op"
//8. Stop
