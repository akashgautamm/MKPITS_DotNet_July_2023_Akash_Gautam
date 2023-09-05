#include<iostream>
using namespace std;
class employee
{
	public:
	int num;
	string name;
	string desi;
	int sal;
	void data()
	{
		cout<<"Emp num"<<"Emp name"<<"Emp desig"<<"Emp salary";
		cin>>num>>name>>desi>>sal;
	}
	void display()
	{
		cout<<"Emp num="<<num<<endl;
		cout<<"Emp name="<<name<<endl;
		cout<<"Emp desi="<<desi<<endl;
		cout<<"Emp sal="<<sal<<endl;
	}
};
int main()
{
	employee e1,e2;
	cout<<"Employee 1"<<endl;
	e1.data();
	e1.display();
	cout<<"Employee 2"<<endl;
	e2.data();
	e2.display();
	return 0;
}
