#include<stdio.h>
void main()
{
	int counter=1,num,result;
	printf("Enter table ");
	scanf("%d",&num);
	while(counter<=10)
	{
		result=num*counter;
		counter=counter+1;
		printf("%d\n",result);
	}
}

//1.Start
//2.Declare num,result,counter
//3.Accept num
//4.Check counter<10
//  4.1 result=num*counter
//  4.2 counter=counter+1
//5. printf " result"
//6. Stop

