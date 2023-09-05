#include<iostream>
using namespace std;
class Account
{
	public:
		int acno;
		int bal;
		virtual void deposit(int amt)=0;
		
};
class Saving:public  Account
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
	Account *A;
	Saving s;
	A=&s;
	A->acno=123;
	A->bal=1000;
	A->deposit(500);
	
	Current c;
	A=&c;
	A->acno=456;
	A->bal=1000;
	A->deposit(500);
	return 0;
}
	
