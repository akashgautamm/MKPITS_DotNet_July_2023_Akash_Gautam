#include <stdio.h>
void main()
{
	int num;
	printf("Enter num");
	scanf("%d",&num);
	switch(num%2==0)
	{
		case 1:
			printf("number is even");
			break;
		default:
		    printf("number is odd");
		    break;
		
			
	}
}

//1.Start
//2.Accept num
//3.Formula for switch (num%2==0) then,
//4.case 1 printf("number is even")
//5.default printf("number is odd")
//6.Stop

