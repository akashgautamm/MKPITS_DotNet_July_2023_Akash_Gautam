#include<iostream>
using namespace std;
class person
{
	public:
		string name;
		int mno;
	void persondata(string n, int m)
	{
		name=n;
		mno=m;
	}
};
class employe:public person
{
	public:
		int eid;
		int sal;
	void employedata(int e,int s)
	{
		eid=e;
		sal=s;
	}
	void display()
	{
		cout<<"Nmae"<<name<<endl;
		cout<<"Mo no"<<mno<<endl;
		cout<<"Emp id"<<eid<<endl;
		cout<<"Salary"<<sal<<endl;
	}
};
int main()
{
	string ne;
	int no,id,sl;
	cout<<"Employe details ";
	cin>>ne>>no>>id>>sl;
	employe e1;
	e1.persondata(ne,no);
	e1.employedata(id,sl);
	e1.display();
	return 0;
	
	
}
