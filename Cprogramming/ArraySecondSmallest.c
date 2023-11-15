#include<stdio.h>
int main()
{
	int arr[10],i,min1,min2,cnt;
	for(i=0;i<5;i++)
	{
		scanf("%d",&arr[i]);
	}
	min1=min2=arr[0];
	 for(i=0;i<5;i++)
    {
    	
     if (arr[i]<min1)
     {
         min2 = min1;
         min1 = arr[i];
     }
     else if (arr[i]>min2)
     {
         min2 = arr[i];
     }
     
    }
    printf(" 1st Minimum is %d\n",min1);
    printf(" 1st Minimum is %d\n",min2);
	
}
