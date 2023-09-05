#include<iostream>
using namespace std;
class A
{
	public:
		int n1,n2;
		void deta1(int m,int n)
		{
			this->n1=m;
			this->n2=n;
		}
		
};
class B:public A
{
	public:
		void deta2()
		{
			int r=n1+n2;
			cout<<"Result is ="<<r<<endl; 
		} 
};
int main()
{
	B b;
	b.deta1(3,3);
	b.deta2();
	return 0;
}
