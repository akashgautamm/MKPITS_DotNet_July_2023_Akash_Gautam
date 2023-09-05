#include<iostream>
using namespace std;
class circle
{
	public:
		int r;
	    circle()
	    {
	    	 this->r=r;
		}
		float area()
		{
			float a=3.14*r*r;
			return a;
		}
		float circu()
		{
			float c=2*3.14*r;
			return c;
		}
		
};
int main()
{
	float result;
	int r;
	circle c1;
	cout<<"Enter radius :";
	cin>>c1.r;
	result=c1.area();
	cout<<"Area is="<<result<<endl;
	result=c1.circu();
	cout<<"Circ is="<<result<<endl;
	return 0;
}
