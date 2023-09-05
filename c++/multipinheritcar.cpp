#include<iostream>
using namespace std;
class Engine
{
	private:
		int power;
    public:
    	void dataa(int p)
    	{
    		power=p;
		}
	    void start()
	    {
	    	cout<<"Engine start"<<endl;
		}
		void stop()
		{
			cout<<"Engine stop"<<endl;
		}
		void displayP()
		{
			cout<<"Power= "<<power<<endl;
		}
	
		
		
};
class Vehicle
{
	private:
	    string brand;
	    public:
	    	void datab(string b)
	    	{
	    		brand=b;
			}
			void accelerate()
			{
				cout<<"Accelerate"<<endl;
			}
			void braek()
			{
				cout<<"Break"<<endl;
			}
			void displayB()
			{
				cout<<"Brand= "<<brand<<endl;
				
			}
};
class Car:public Engine,public Vehicle
{
	public:
		void drive()
		{
			cout<<"Car drive"<<endl;
			
		}
		void park()
		{
			cout<<"Car park"<<endl;
		}
};
int main()
{
	Car c1;
	c1.datab("Swift");
	c1.displayB();
	c1.dataa(1200);
	c1.displayP();
	c1.start();
	c1.drive();
	c1.accelerate();
	c1.braek();
	c1.park();
	c1.stop();
	return 0;
}
