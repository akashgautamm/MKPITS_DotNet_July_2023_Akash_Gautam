#include<iostream>
using namespace std;
class Media
{
	public:
		virtual void play()=0;
		virtual void pause()=0;
		virtual void stop()=0;
};
class Audio:public Media
{
	public:
		void play()
		{
			cout<<"Audio is play"<<endl;
		}
		void pause()
		{
			cout<<"Audio is pause"<<endl;
		}
		void stop()
		{
			cout<<"Audio is stop"<<endl;
		}
};
class Video:public Media
{
	public:
		void play()
		{
			cout<<"Video is play"<<endl;
		}
		void pause()
		{
			cout<<"Video is pause"<<endl;
		}
		void stop()
		{
			cout<<"Video is stop"<<endl;
		}
		
};
int main()
{
	Audio a;
	Video v;
	a.pause();
	a.play();
	a.stop();
	v.pause();
	v.play();
	v.stop();
	return 0;
}
