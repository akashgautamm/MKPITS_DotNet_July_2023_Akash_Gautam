#include<iostream>
using namespace std;
int square(int num)
{
	int result=num*num;
	return result;
}
int main()
{
	int num,result=0;
	cout<<"Enter num :";
	cin>>num;
	result=square(num);
	cout<<"Area is = "<<result;
	return 0;
}
