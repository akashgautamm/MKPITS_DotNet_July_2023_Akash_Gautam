#include<iostream>
using namespace std;
class student
{
	private:
		int rno;
	public:
		void display()
		{
			cout<<"rno ="<<rno;
		}
		void getdata(int r)
		{
			rno=r;
		}
		
};
int main()
{
	student s1;
	int rn;
	cout<<"Enter rno :";
	cin>>rn;
	s1.getdata(rn);
	s1.display();
	return 0;
}
