#include<stdio.h>
void main()
{
	int counter=1,result,num;
	printf("Enter table");
	scanf("%d",&num);
	do
	{
		result=num*counter;
		counter=counter+1;
		printf("%d\n",result);
		
	}
	while(counter<=10);
}
//1.Start
//2.Declare num,result,counter
//3.Accept num
//4.Check counter<10
//  4.1 result=num*counter
//  4.2 counter=counter+1
//5. printf " result"
//6. Stop
