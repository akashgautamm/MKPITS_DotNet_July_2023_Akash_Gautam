#include<iostream>
using namespace std;
class calculate
{
	public:
		int add(int n1,int n2)
		{
			return n1+n2;
		}
		float add(float n1,float n2)
		{
			return n1+n2;
		}
};
int main()
{
	calculate c;
	cout<<"Addition 2 int num :"<<c.add(2,3)<<endl;
	cout<<"Addition 2 float num :"<<c.add(2.0f,3.0f);
	return 0;
}
