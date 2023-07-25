#include<stdio.h>
void main()
{
	int fact=1;
	int num;
	printf("Enter num :");
	scanf("%d",&num);
	do
	{
		fact=fact*num;
		num=num-1;
		
	}
	while(num>0);
	printf("fact is %d",fact);
}

//1.Start
//2.Declare num, fact=1
//3.Accept num
//4.Check num>0
//  4.1 fact=fact*num
//  4.2 num=num-1
//5. printf " fact"
//6. Stop

