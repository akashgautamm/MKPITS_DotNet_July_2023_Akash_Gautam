#include<iostream>
using namespace std;
class classA
{
	protected:
		int n1;
	public:
		void datan1(int n)
		{
			n1=n;
		}
};
class classB
{
	protected:
		int n2;
	public:
		void datan2(int n)
		{
			n2=n;
		}
};
class classC:public classA,public classB
{
	public:
		void display()
		{
			cout<<"n1="<<n1<<endl;
			cout<<"n2="<<n2<<endl;
			cout<<"Total="<<n1+n2<<endl;
			
		}
};
int main()
{
	classC c1;
	c1.datan1(5);
	c1.datan2(4);
	c1.display();
	return 0;
}
