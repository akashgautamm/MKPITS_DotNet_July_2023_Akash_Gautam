#include<iostream>
using namespace std;
int main()
{
	int n;
	int n1=0;
	int n2=1;
	int add;
	int i;
	cout<<"Enter num:"<<endl;
	cin>>n;
	for(i=0;i<=n;i++)
	{
		cout<<add<<endl;
		add=n1+n2;
		n1=n2;
		n2=add;
		
	}
	return 0;
}
