#include <stdio.h>
void main()
{
	int n1,n2;
	printf("Enter  age 1:");
	scanf("%d",&n1);
	printf("Enter age 2 ");
	scanf("%d",&n2);
	if (n1>60)
	{
		printf("%d is old",n1);
	}
	else
	{
		printf("%d is adult");
	}
}
