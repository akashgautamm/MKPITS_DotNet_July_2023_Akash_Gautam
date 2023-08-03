//Write a program to print all unique elements in an array....
#include<stdio.h>
void main()
{
	int i,j,arr[5],count=0;
	for(i=0;i<5;i++)
	{
		printf("Enter num :");
		scanf("%d",&arr[i]);
	}
	for(i=0;i<5;i++)
	{
		count=0;
		for(j=0;j<5;j++)
		{
			if(i!=j)
			{
				if(arr[i]==arr[j])
				{
					count++;
					break;
				}
			}
		}
		if(count==0)
		{
			printf("Unique =%d\n",arr[i]);
		}
	}
}
//1.Start
//2.Declare i,j,arr[5],cnt=0
//3.Check for i=0;i<5;i++, then
//  3.1 Declare num as an integer
//4.Check for i=0;i<5;i++, then
//   cnt=0
//5. Check for j=0;j<5;j++, then
//  5.1 Check if (i!=j)
//  5.2 Check arr[i]==arr[j]
//      cnt++
//6 Check if(cnt==0)
//7.print"arr[i]"
//8.Stop
