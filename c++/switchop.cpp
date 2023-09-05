#include<iostream>
using namespace std;
int main()
{
	int n1,n2,sum=0;
	char op;
	cout<<"Enter num :";
	cin>>n1>>n2;
	cout<<"Enter op(+,-,*,/)";
	cin>>op;
	switch(op)
	{
		case'+':
		sum=n1+n2;
		break;
		case'-':
		sum=n1-n2;
		break;
		case'*':
		sum=n1*n2;
		break;
		case'/':
		sum=n1/n2;
		break;
	}
	cout<<"sum is= "<<sum;
	return 0;
}
