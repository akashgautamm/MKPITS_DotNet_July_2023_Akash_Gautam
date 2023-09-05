#include<iostream>
using namespace std;
class Vehicle
{
	public:
		virtual void start ()
		{
			cout<<"Engine is start"<<endl;
		}
		virtual void stop()
		{
			cout<<"Engine is stop"<<endl;
		}
		
};
class Car:public Vehicle
{
	public:
		void start()
		{
			cout<<"Car is start"<<endl;
		}
		void stop()
		{
			cout<<"Car is stop"<<endl;
		}
		
};
class Truck:public Vehicle
{
	public:
		void start()
		{
			cout<<"Truck is start"<<endl;
			
		}
		void stop()
		{
			cout<<"Truck is stop"<<endl;
		}
};
class Cycle:public Vehicle
{
	public:
		void start()
		{
			cout<<"Cycle is start"<<endl;
		}
		void stop()
		{
			cout<<"Cycle is stop"<<endl;
		}
};
int main()
{
	Vehicle*V;
	Vehicle v;
	Car c;
	Truck t;
	Cycle b;
	V=&v;
	V->start();
	V->stop();
	V=&c;
	V->start();
	V->stop();
	V=&t;
	V->start();
	V->stop();
	V=&b;
	V->start();
	V->stop();
	return 0;
}
