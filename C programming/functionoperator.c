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



