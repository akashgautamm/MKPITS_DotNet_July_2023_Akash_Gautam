#include<iostream>
using namespace std;
class Account
{
	public:
		int acno;
		int bal;
		static float roi;
		Account(int acno, int bal)
		{
			this->acno=acno;
			this->bal=bal;
		}
		void display()
		{
			cout<<"Account no ="<<acno<<endl;
			cout<<"Balance ="<<bal<<endl;
			cout<<"Rate of int ="<<roi<<endl;
		}
};
float Account::roi=9.5f;
int main()
{
	Account A1=Account(123,1000);
	Account A2=Account(456,2000);
	A1.display();
	A2.display();
	return 0;
}
