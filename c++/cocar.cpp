#include<iostream>
using namespace std;
class car
{
	public:
		string make;
		string model;
		int year;
		void engine()
		{
			cout<<"Engine start"<<endl;
			
		}
		void stop()
		{
			cout<<"Break applied";
		}
};
int main()
{
	car c1;
	c1.make="Maruti suzuki";
	c1.model="XUV";
	c1.year=2022;
	cout<<"Make="<<c1.make<<endl;
	cout<<"Model="<<c1.model<<endl;
	cout<<"Year="<<c1.year<<endl;
	c1.engine();
	c1.stop();
	return 0;
}
