#include<stdio.h>
void main()
{
	int counter=1;
	int sum=0;
	do
	{
		sum=sum+counter;
		counter=counter+1;
	}
	while(counter<=5);
	{
	    printf("sum is %d",sum);
    }
}
   
//1.Start
//2.Declare counter=2
//3.If counter<=5. then if true
//  3.1 sum=sum+counter
//  3.2 counter = counter+1
//  3.3 go to step 3
//  3.4 go to step 5
//4. Print "sum"
//5.Stop

