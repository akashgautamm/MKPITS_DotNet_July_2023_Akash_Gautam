#include<iostream>
using namespace std;
class calculate
{
	public:
		int add(int n1,int n2)
		{
			return n1+n2;
		}
		int add(int n1,int n2,int n3)
		{
			return n1+n2+n3;
		}
};
int main()
{
	calculate c;
	cout<<"Addition of 2 num :"<<c.add(2,3)<<endl;
	cout<<"Addition of 3 num :"<<c.add(2,3,4);
	return 0;
}
