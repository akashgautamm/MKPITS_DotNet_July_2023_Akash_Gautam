#include<iostream>
using namespace std;
int oddeven(int num)
{
	if(num%2==0)
	{
		cout<<"No is even";
	}
	else
	{
		cout<<"No is odd";
	}
}
int main()	
{
	int num;
	cout<<"Enter num :";
	cin>>num;
	oddeven(num);
	return 0;
}
