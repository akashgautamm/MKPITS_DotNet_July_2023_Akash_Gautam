#include <iostream>
using namespace std;
struct student
{
	char name[20];
	int fees,month,day;
};
int main()
{
	struct student s[2];
	int month,day,counter,fees;
	for(counter=0;counter<2;counter++)
	{
		cout<<"Enter name and Fees :";
		cin>>s[counter].name>>s[counter].fees;
	}
	for(counter=0;counter<2;counter++)
	{
		month=20*5;
		s[counter].day=s[counter].fees/month;
		cout<<"\nPer day rs is ="<<s[counter].day;
	}
	return 0;
}
