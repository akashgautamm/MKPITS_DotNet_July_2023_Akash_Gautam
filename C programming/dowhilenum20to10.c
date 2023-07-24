#include<stdio.h>
void main()
{
	int counter=20;
	do
	{
		printf("\n%d",counter);
		counter=counter-1;
	}
	while(counter>=10);
	
}

//1.Start
//2.Declare counter=20
//3.If counter<=10. then if true
//  3.1 counter = counter+1
//  3.2 go to step 3
//  3.3 go to step 5
//4.print"counter"
//5.Stop
