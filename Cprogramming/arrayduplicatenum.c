#include<stdio.h>
void main()
{
	int arr[5];
	int i,j;
	int counter=0;
	for(i=0;i<5;i++)
	{
		printf("Enter num :");
		scanf("%d",&arr[i]);
	}
	for(i=0;i<5;i++)
	{
		for(j=i+1;j<5;j++)
		{
			if(arr[i]==arr[j])
			{
				counter++;
				break;
			}
			
		}
		
	}
	printf("\nDuplicate num is=%d",counter);
}
