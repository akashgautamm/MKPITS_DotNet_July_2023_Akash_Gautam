#include<iostream>
using namespace std;
class Animals
{
	public:
		virtual void sound()
		{
			cout<<"Animals sound"<<endl;
		}
};
class Dog:public Animals
{
	public:
		void sound()
		{
			cout<<"Dog = bark"<<endl;
		}
};
class Cat:public Animals
{
	public:
		void sound()
		{
			cout<<"Cat = meau"<<endl;
		}
};
class Cow:public Animals
{
	public:
		void sound()
		{
			cout<<"Cow = ummm"<<endl;
		}
};
int main()
{
	Animals*A;
	Animals a;
	A=&a;
	
	Dog d;
	Cat c;
	Cow g;
	A->sound();
	A=&d;
	A->sound();
	A=&c;
	A->sound();
	A=&g;
	A->sound();
	return 0;
}
