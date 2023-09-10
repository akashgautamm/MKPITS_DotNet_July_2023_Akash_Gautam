//Write a program to find maximum and minimum element in array....
#include<stdio.h>
void main()
{
	int i,arr[5],max,min;
	for(i=0;i<5;i++)
	{
		printf("Enter num :");
		scanf("%d",&arr[i]);
	}
	max=arr[0];
	for(i=0;i<5;i++)
	{
		if(arr[i]>max)
		{
			max=arr[i];
		}
	}
	min=arr[0];
	for(i=0;i<5;i++)
	{
		if(arr[i]<min)
		{
			min=arr[i];
		}
	}
	printf("Maximum value : %d\n",max);
	printf("Minimum value : %d\n",min);
}

//1.Start
//2.Declare i,arr[5],max,min
//3.Check for i=0;i<5;i++, then
//  3.1 Declare num as an integer
//4  max=arr[0]
//5.Check for i=0;i<5;i++, then
//  5.1 Check if arr[i]>max
//      then max=arr[i]
//6 min=arr[o]
//7. Check for i=0;i<5;i++, then
//  7.1 Check if arr[i]<min
//      then min=arr[i]
//8 print"max"
//9.print"min"
//10.Stop
