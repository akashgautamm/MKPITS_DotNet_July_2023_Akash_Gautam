#include<stdio.h>
void main()
{
	int num=1;
	int cube;
	int i;
	printf("Enter num :");
	scanf("%d",&num);
	for(i=1;i<=num;i++)
	{
		cube=i*i*i;
		printf("\n%d is a cube of %d",i,cube);
	}
}

//1.Start
//2.Declare num=1,cube,i
//3.Check with for loop i=1;i<=num;i++then
//  3.1cube=i*i*i
//  3.2printf"cube"
//4.Stop
