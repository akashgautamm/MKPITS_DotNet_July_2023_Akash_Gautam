#include<iostream>
using namespace std;
class bank
{
	public:
	int acno;
	int bal;
	int deposite()
	{
		int amt;
		cout<<"Enter deposite amount :";
		cin>>amt;
		bal=bal+amt;
		cout<<"Deposite balance ="<<bal;
		return amt;
	}
	int withdrawl()
	{
		int amt;
		cout<<"\nEnter withdrawl amount :";
		cin>>amt;
		bal=bal-amt;
		cout<<"Withdrawl balance ="<<bal;
		return amt;
	}
};
int main()
{
	bank b1;
	cout<<"Enter acno and balance :";
	cin>>b1.acno>>b1.bal;
	b1.deposite();
	b1.withdrawl();
	return 0;
}
