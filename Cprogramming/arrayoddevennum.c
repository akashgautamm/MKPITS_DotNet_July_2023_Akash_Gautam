//Write a programm seprate odd and even num into a array...
#include<stdio.h>
void main()
{
	int i,arr[5];
	for(i=0;i<5;i++)
	{
		printf("Enter num :");
		scanf("%d",&arr[i]);
    }
    for(i=0;i<5;i++)
    {
	
		if(arr[i]%2==0)
		{
			printf("\nNum is even = %d",arr[i]);
		}
		else
		{
			printf("\nNum is odd = %d",arr[i]);
		}
	}
}
//1.Start
//2.Declare i,arr[5]
//3.Declare num as an integer
//4.Check for i=0;i<5;i++, then
//5.Check if arr[i]%2==0
//  5.1 print"no is even arr[i]"
//  5.2 print "no is odd arr[i]"
//6.Stop

