#include<stdio.h>
void main()
{
	int num1=0;
	int num2=1;
	int add=num1+num2;
	int i;
	printf("%d,%d",num1,num2);
	for(i=3;i<10;i++)
	{
		printf(",%d",add);
		num1=num2;
		num2=add;
		add=num1+num2;
	}
}

//1.Start
//2.Declare num1,num2,add
//3.Check with for loop i=3,i<10,i++, then
//  3.1printf "add"
//  3.2num1=num2
//  3.3num2=add
//  3.4add=num1+num2
//4.Stop
