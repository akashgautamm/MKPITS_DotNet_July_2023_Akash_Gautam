#include<iostream>
using namespace std;
class Account
{
	public:
		int acno;
		int bal;
		virtual void deposit(int amt)
		{
			cout<<"Hello to account deposite :"<<endl;
		}
};
class Saving:public Account
{
	public:
		void deposit(int amt)
		{
			int intrest=500;
			bal=bal+intrest+amt;
			cout<<"Balance with intrest ="<<bal<<endl;
		}
};
class Current:public Account
{
	public:
		void deposit(int amt)
		{
			bal=bal+amt;
			cout<<"Balance is ="<<bal<<endl;
		}
};
int main()
{
	Account*A;
	Saving s;
	Current c;
	A=&s;
	A->acno=123;
	A->bal=1000;
	A->deposit(500);
	A=&c;
	A->acno=456;
	A->bal=4000;
	A->deposit(500);
	return 0;
	
}
