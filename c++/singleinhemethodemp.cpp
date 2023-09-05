#include<iostream>
using namespace std;
class person
{
	public:
		void x()
		{
			char name[10];
	        char adrs[10];
	        cout<<"Name , Adress";
		}
	
};
class employe:public person
{
	public:
	void y()
	{
		int sal;
	    string des;
	}
	
};
int main()
{
	class employe e1;
	cout<<"Name, Adress, Salary, Design :";
	cin>>e1.name>>e1.adrs>>e1.sal>>e1.des;
	cout<<e1.name<<endl<<e1.adrs<<endl<<e1.sal<<endl<<e1.des<<endl;
	e1.x();
	e1.y();
	return 0;
}
