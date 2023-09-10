#include<stdio.h>
void main()
{
	int counter=20;
	while(counter<=30)
	{
		if(counter%2==1)
		{
			printf("\n%d",counter);
		}
		counter=counter+1;
	}
}


//1.Start
//2.Declare counter=20
//3.If counter<=30. then if true
//4.Check counter%2==1
//  4.1 print "counter"
//  4.2 counter=counter+1
//  3.4 go to step 4
//4.Stop

