#include<iostream>
using namespace std;
class person
{
	public:
		string name;
		int mno;
};
class employe:public person
{
	public:
		int empid;
		int sal;
};
class parttime:public employe
{
	public:
		int hrs;
};
int main()
{
	employe e1;
	e1.name="Akash";
	e1.mno=997075;
	e1.empid=123;
	e1.sal=50000;
	cout<<"Employe details"<<endl;
	cout<<e1.name<<endl<<e1.mno<<endl<<e1.empid<<endl<<e1.sal<<endl;
	parttime p1;
	p1.name="Chandrima";
	p1.mno=80078;
	p1.empid=345;
	p1.sal=40000;
	p1.hrs=5;
	cout<<"Parttime employe details"<<endl;
	cout<<p1.name<<endl<<p1.mno<<endl<<p1.empid<<endl<<p1.sal<<endl<<p1.hrs<<endl;
	return 0;
	
}
