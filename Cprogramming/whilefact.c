#include<stdio.h>
void main()
{
	int num;
	int fact=1;
	printf("Enter num :");
	scanf("%d",&num);
	while(num>0)
	{
		fact=fact*num;
		num=num-1;
		
    }
    printf("Fact is %d",fact);
}


//1.Start
//2.Declare num, fact=1
//3.Accept num
//4.Check num>0
//  4.1 fact=fact*num
//  4.2 num=num-1
//5. printf " fact"
//6. Stop

