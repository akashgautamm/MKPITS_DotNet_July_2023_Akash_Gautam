#include<iostream>
using namespace std;
class employe
{ 
    public:
	int num;
	string name;
	employe(int en,string ena)
	{
		num=en;
		name=ena;
	}
	void display()
	{
		cout<<"Employe num :"<<num<<endl;
		cout <<"Employe name :"<<name<<endl;
	}
	
};
int main()
{
	int en;
	string ena;
	cout<<"Emplye num and Employe name :";
	cin>>en>>ena;
	employe e1(en,ena);
	e1.display();
	return 0;
}
