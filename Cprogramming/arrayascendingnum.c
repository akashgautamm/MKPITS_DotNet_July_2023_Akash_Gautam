//write a program to short array in ascending order...
#include<stdio.h>
void main()
{
	int i,j,arr[5],temp;
	for(i=0;i<5;i++)
	{
		printf("Enter num :");
		scanf("%d",&arr[i]);
	}
	for(i=0;i<5;i++)
	{
		for(j=i+1;j<5;j++)
		{
			if(arr[i]>=arr[j])
			{
				temp=arr[i];
				arr[i]=arr[j];
				arr[j]=temp;
			}
		}
	}
	printf("Ascending order :");
	for(i=0;i<5;i++)
	{
		printf("%d",arr[i]);
	}
}
//1.Start
//2.Declare i,j,arr[5]
//3.Check for i=0;i<5;i++, then
//  3.1 Declare num as an integer
//4.Check for i=0;i<5;i++, then
//5. Check for j=i+1;j<5;j++, then
//6. Check if arr[i]>arr[j]
//  6.1 temp=arr[i]
//    arr[i]=arr[j]
//    arr[j]=temp
//7.print"ascending order"
//8.Check for i=0;i<5;i++, then
//  8.1 print"arr[i]
//9. Stop

