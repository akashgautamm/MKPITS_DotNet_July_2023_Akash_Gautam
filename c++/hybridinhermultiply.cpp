#include<iostream>
using namespace std;
class ClassA
{
	protected:
		int n1;
		public:
			void get1(int n)
			{
				n1=n;
			}
};
class ClassB:public ClassA
{
	protected:
		int n2;
		public:
			void get2(int n)
			{
				n2=n;
			}
};
class ClassC
{
	protected:
		int n3;
		public:
			void get3(int n)
			{
				n3=n;
			}
};
class ClassD:public ClassB,public ClassC
{
		public:
			
			int multiply()
			{
				int m=n1*n2*n3;
				return m;
			}
};
int main()
{
	int r;
	ClassD d;
	d.get1(2);
	d.get2(2);
	d.get3(2);
	r=d.multiply();
	cout<<"Multiply ="<<r;
	return 0;
}

