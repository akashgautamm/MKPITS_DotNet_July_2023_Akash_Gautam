#include<iostream>
using namespace std;
class student
{
	public:
		int rno;
		string name;
		string course;
		void data()
		{
			cout<<"Rollnum "<<"Name "<<"Course";
			cin>>rno>>name>>course;
		}
		void display()
		{
			cout<<"Roll num :"<<rno<<endl;
			cout<<"Name :"<<name<<endl;
			cout<<"Course :"<<course<<endl;
		}
};
int main()
{
	student s1,s2;
	cout<<"Student 1:"<<endl;
	s1.data();
	s1.display();
	cout<<"Student 2:"<<endl;
	s2.data();
	s2.display();
	return 0;
}
