#include<iostream>
using namespace std;
class Employe
{
	public:
		int eno;
		string name;
		static string cname;
		Employe(int eno,string name)
		{
			this->eno=eno;
			this->name=name;
		}
		void display()
		{
			cout<<"Employe no ="<<eno<<endl;
			cout<<"Employe name ="<<name<<endl;
			cout<<"Company no ="<<cname<<endl;
		}
};
string Employe::cname="Mkpit";
int main()
{
	Employe E1=Employe(123,"akash");
	Employe E2=Employe(456,"Ashish");
	E1.display();
	E2.display();
	return 0;
	
}
