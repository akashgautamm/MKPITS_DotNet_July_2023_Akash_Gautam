#include<iostream>
using namespace std;
class Game
{
	public:
		virtual void start()=0;
		virtual void play()=0;
		virtual void end()=0;
};
class Tiktakto:public Game
{
	public:
		void start()
		{
			cout<<"Tik-Tak-Toe is starting"<<endl;
		}
		void play()
		{
			cout<<"Tik-Tak-Toe is playing"<<endl;
		}
		void end()
		{
			cout<<"Tik-Tak-Toe is ended"<<endl;
		}
};
class Chess:public Game
{
	public:
		void start()
		{
			cout<<"Chess is starting"<<endl;
		}
		void play()
		{
			cout<<"Chess is playing"<<endl;
		}
		void end()
		{
			cout<<"chess is ended"<<endl;
		}
		
};
int main()
{
	Tiktakto t;
	Chess c;
	t.start();
	t.play();
	t.end();
	c.start();
	c.play();
	c.end();
	return 0;
}
