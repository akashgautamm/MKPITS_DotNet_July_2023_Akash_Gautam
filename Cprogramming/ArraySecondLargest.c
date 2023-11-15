#include<stdio.h>
int main()
{
	int arr[10],i,max1,max2,cnt;
	for(i=0;i<5;i++)
	{
		scanf("%d",&arr[i]);
	}
	max1=max2=arr[0];
	 for(i=0;i<5;i++)
    {
    	
     if (arr[i]>max1)
     {
         max2 = max1;
         max1 = arr[i];
     }
     else if (arr[i]>max2)
     {
         max2 = arr[i];
     }
     
    }
    printf("%d 1st Maximum is ",max1);
    printf("%d 1st Minimum is ",max2);
	
}
