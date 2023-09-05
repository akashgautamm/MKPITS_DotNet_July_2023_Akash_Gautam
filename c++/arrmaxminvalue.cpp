#include<iostream>
using namespace std;
int main()
{
	int counter;
	int arr[5],max,min;
	for(counter=0;counter<5;counter++)
	{
		cout<<"Enter num :";
		cin>>arr[counter];
	}
	max=arr[0];
	for(counter=0;counter<5;counter++)
	{
		if(arr[counter]>max)
		{
			max=arr[counter];
		}
	}
	min=arr[0];
	for(counter=0;counter<5;counter++)
	{
		if(arr[counter]<min)
		{
			min=arr[counter];
		}
	}
	cout<<"Maximum value is ="<<max;
	cout<<"\nMinimum value is ="<<min;
	return 0;
}
