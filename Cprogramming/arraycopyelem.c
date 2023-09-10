#include<stdio.h>
void main()
{
	int i,array1[5],array2[5];
	for(i=0;i<5;i++)
	{
		printf("Enter num");
		scanf("%d",&array1[i]);
	}
	for(i=0;i<5;i++)
	{
		array2[i]=array1[i];
	}
	printf("Elements of array 1 : ");
	for(i=0;i<5;i++)
	{
		printf("%d",array1[i]);
	}
	printf("\nElements of array 2 : ");
	for(i=0;i<5;i++)
	{
		printf("%d",array2[i]);
	}
}
//1.Start
//2.Declare int i,array1[5],array2[5]
//3.Check for i=0;i<5;i++, then
//  3.1 read num
//4.Check for i=0;i<5;i++, then
//  4.1 array2[i]=array1[i]
//5.Check for i=0;i<5;i++, then
//  5.1 print"array1[i]"
//6.Check for i=0;i<5;i++, then
//  6.1 print"array1[i]"
//7.Stop
