#include<iostream>
using namespace std;
class Animal
{
	public:
		void animal()
		{
			cout<<"Animals"<<endl;
		}

};
class Mammal:public Animal
{
	public:
	void data1()
	{
		cout<<"Mammals are animal"<<endl;
	}
};
class Bird:public Animal
{
	public:
	void data2()
	{
		cout<<"Birds are bird"<<endl;
	}
};
class Reptile:public Animal
{
	public:
	void data3()
	{
		cout<<"Snake are insect"<<endl;
	}
};
int main()
{
	Animal A;
	A.animal();
	A.data1();
	A.data2();
	A.data3();
	return 0;
}
