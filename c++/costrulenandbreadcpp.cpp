#include<iostream>
using namespace std;
class rectangle
{
	public:
		int length;
		int breadth;
		rectangle()
		{
			length=0;
			breadth=0;
		}
		float calarea()
		{
			float area =length*breadth;
			return area;
		}
		float calperi()
		{
			float peri=2*(length+breadth);
			return peri;
		}
};
int main()
{
	int length,breadth,result;
	rectangle r1;
	cout<<"Enter length and breadth";
	cin>>r1.length>>r1.breadth;
	result=r1.calarea();
	cout<<"Area is ="<<result<<endl;
	result=r1.calperi();
	cout<<"Peri is ="<<result<<endl;
	return 0;
}
