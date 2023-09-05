#include<iostream>
using namespace std;
class employe
{
	public:
		int num;
		string name;
		employe()
		{
			num=123;
			name="Ashish";
		}
		void display()
		{
			cout<<"Emp num :"<<num<<endl;
			cout<<"Emp name :"<<name<<endl;
		}
};
int main()
{
	employe e1;
	e1.display();
	return 0;
}
