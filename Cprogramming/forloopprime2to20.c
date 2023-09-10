#include<stdio.h>
void main()
{
	int counter=2;
	int rem=0;
	int num;
	for(num=3;num<=20;num++)
	{
		counter=2;
		while(counter<num)
		{
			rem=num%counter;
			if(rem==0)
			{
				break;
			}
			counter++;
		}
		if(num==counter)
		{
			printf("%d is a prime\n",num);
		}
		
	}
}

//1.Start
//2.Declare counter=2,rem=0,num
//3.Check with for loop num=3,num<=20 ,num++ then
//4.Check with while loop (counter<num) so
//  4.1 rem=num%counter;
//5.Check with if (rem==0)
//  5.1break;
//6.Check with if(num==counter)
//   6.1print"num
//7.Stop
