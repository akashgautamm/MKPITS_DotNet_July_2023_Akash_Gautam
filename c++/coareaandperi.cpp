#include<iostream>
using namespace std;
class rectangle
{
	public:
	int length,breadth;
	float area()
	{
		float a=length*breadth;
		return a;
	}
	float peri()
	{
		float p=2*(length+breadth);
		return p;
	}
};
int main()
{
	float result;
	rectangle r1;
	cout<<"Enter length and breadth";
	cin>>r1.length>>r1.breadth;
	result=r1.area();
	cout<<"Area is ="<<result;
	result=r1.peri();
	cout<<"Perimeter is ="<<result;
	return 0;
}
