
#include<iostream>
using namespace std;
class Shape
{
	public:
		virtual void draw()=0;
};
class Rectangle
{
	public:
		void draw()
		{
			cout<<"Draw rectangle";
		}
};
int main()
{
	Rectangle r;
	r.draw();
	return 0;
}
