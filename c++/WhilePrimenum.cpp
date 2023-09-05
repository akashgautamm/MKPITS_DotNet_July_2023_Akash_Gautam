#include<iostream>
using namespace std;
int main()
{
	int num;
	int rem=0;
	int counter=2;
	cout<<"Enter num= ";
	cin>>num;
	while(counter<num)
	{
		rem=num%counter;
		if(rem==0)
		{
			cout<<"It is a not prime num";
			break;
		}
		counter=counter+1;
		if (num==counter)
		{
			cout<<"It is a prime num";
		}
	}
	return 0;
	
}
