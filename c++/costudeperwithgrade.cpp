#include<iostream>
using namespace std;
class student
{
	public:
	char name[20];
	int std;
	int rno;
	float m1,m2,m3,per;
	void data()
	{
		cout<<"Name "<<"Std "<<"Rno ";
		cin>>name>>std>>rno;
	}
	float marks()
	{
		cout<<"Enter 3 subject marks:";
		cin>>m1>>m2>>m3;
		per=(m1+m2+m3)/300*100;
		if(per>75)
		{
			cout<<"Grade is topper";
		}
		else if(per>60 && per<=75)
		{
			cout<<"Grade is first";
		}
		else if(per>40 && per<=60)
		{
			cout<<"Grade is second";
		}
		else
		{
			cout<<"Fail";
		}
		return per;
	}
	void details()
	{
		cout<<"\nName ="<<name<<endl;
		cout<<"Std ="<<std<<endl;
		cout<<"Roll no ="<<rno<<endl;
		cout<<"Per is ="<<per<<endl;
	}
	
};
int main()
{
	student s1;
	cout<<"Student details:"<<endl;
	s1.data();
	s1.marks();
	s1.details();
	return 0;
}
