#include<iostream>
using namespace std;
class Shape
{
	public:
		virtual void draw()
		{
			cout<<"Draw method of shape class"<<endl;
		}
};
class Rectangle:public Shape
{
	public:
		void draw()
		{
			cout<<"Draw method of rectangle shape"<<endl;
		}
};
int main()
{
	Shape *s;
	Shape s1;
	Rectangle r1;
	s=&s1;
	s->draw();
	s=&r1;
	s->draw();
	return 0;
}
