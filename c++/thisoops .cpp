#include<iostream>
using namespace std;
class employe
{
	public:
	int empnum;  //instance variable
	string empname;
	employe (int empnum,string empname)
	{
		this->empnum=empnum;
		this->empname=empname;
	}
	void display()
	{
		cout<<"EMp num"<<empnum<<endl;
		cout<<"name"<<empname<<endl;
	}
	
};
int main()
{
	employe e1(123,"  Sarang Lucky");
	e1.display();
	return 0;
}
