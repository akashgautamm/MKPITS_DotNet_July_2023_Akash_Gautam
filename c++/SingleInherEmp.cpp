#include<iostream>
using namespace std;
class person
{
	public:
		string name;
		string city;
		
};
class employe:public person
{
	public:
	int id;
	int mno;
	void display()
	{
		cout<<"name is"<<name;
		cout<<"city is"<<city;
		cout<<"id is"<<id;
		cout<<"mno"<<mno;
	}
};
int main()
{
	employe e;
	e.name="amit";
	e.city="Nagpur";
	e.id=123;
	e.mno=998087879;
	e.display();
	return 0;
}

