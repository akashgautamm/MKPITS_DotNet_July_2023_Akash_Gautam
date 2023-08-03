#include<stdio.h>
void main()
{
	int i,n,num[100];
	printf("Enter  n");
	scanf("%d",&n);
	for(i=0;i<n;i++)
	{
		printf("Enter num");
		scanf("%d",&num[i]);
	}
	for(i=n-1;i>=0;i--)
	{
		printf("\n Reverse is =%d",num[i]);
	}
}
//1.Start
//2.Declare i,n,num[100]
//3.Declare num as integer
//4.Check for i=0;i<5;i++, then
//  4.1 Declare num as an integer
//5.Check for i=0;i<5;i++, then
//6.print"num[i]"
//17.Stop
