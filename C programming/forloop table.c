#include<stdio.h>
void main()
{
	int counter;
	int result=0;
	int num;
	printf("Enter table:");
	scanf("%d",&num);
	for(counter=1;counter<=10;counter++)
	{
		result=num*counter;
		printf("%d X %d =%d\n",num,counter,result);
	}
}
//1.Start
//2.Declare counter,result=0,num
//3.Aceept num from user
//4.Check with for loop counter=1,counter<=10,counter++ then
//  4.1result=num*counter;
//  4.2printf"num,counter,result
//5.Stop
