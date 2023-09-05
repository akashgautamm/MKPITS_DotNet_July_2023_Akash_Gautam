#include<iostream>
using namespace std;
class employe
{
	public:
	int num;
	string name;
	employe(int eno,string en)
	{
		num=eno;
		name=en;
	}
	void display()
	{
		cout<<"Employe num:"<<num<<endl;
		cout<<"Employe name:"<<name<<endl;
	}
};
int main()
{
	int eno;
	string en;
	employe e1(11,"Akash");
	e1.display();
	return 0;

}
