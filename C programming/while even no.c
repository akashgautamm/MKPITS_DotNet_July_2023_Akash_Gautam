#include<stdio.h>
void main()
{
	int counter=2;
	while(counter<=10)
	{
		if(counter%2==0)
		{
			printf("\n%d",counter);
		}
		counter=counter+1;
	}
}

//1.Start
//2.Declare counter=2
//3.Check counter<=10
//4.if check counter%2==0
//  4.1 printf "counter"
//  4.2 counter=counter+1
//  4.3 go to step 5
//5.Step
