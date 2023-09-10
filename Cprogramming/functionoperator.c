#include <stdio.h>
void calculate(int num1,int num2,char op)
{
	int result=0;
	switch(op)
	{
		case '+':
			result=num1+num2;
		break;
		case '-':
			result=num1-num2;
		break;
		case '*':
			result=num1*num2;
		break;
		case '/':
			result=num1/num2;
		break;
	}
	printf("Result is %d\n",result);
}
void main()
{
	int num1,num2,result;
	char ch='y';
	char op;
	while(ch='y')
	{
		printf("Enter two num  :");
	    scanf("%d%d",&num1,&num2);
	    printf("Enter operator(+,-,*,/)\n");
	    fflush(stdin);
	    scanf("%c",&op);
	    calculate(num1,num2,op);
	    printf("Do you want continue,press y\n");
	    fflush(stdin);
	    scanf("%c",&ch);
	
		
    }
	
}
//1.Start
//2.Define the function "calculate"
//  2.1 Accept num1,num2,char op
//  2.3 Formula is result=num1 (op) num2
//3.Check switch(-,*,/,+)
//  3.1 print"result"
//4. Go to main function
//  4.1 Check while ch='y'
//  4.2 Read two num with user
//  4.3 Choose the op
//  4.4 Call function calculate num1,num2,op 
//  4.5 print "do you want continue press y"
//5.Stop



