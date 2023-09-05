#include<iostream>
using namespace std;
class Ability
{
	protected:
		string abiname;
	public:
		void abilityname(string an)
		{
			abiname=an;
		}
};
class Equipment
{
	protected:
		string eqname;
	public:
		void equipname(string ei)
		{
			eqname=ei;
		}
};
class Character:public Ability,public Equipment
{
	protected:
		string character;
	public:
		void charactername(string ch)
		{
			character=ch;
		}
		void display()
		{
			cout<<"Char name="<<character<<endl;
			cout<<"Ability ="<<abiname<<endl;
			cout<<"Eqip item ="<<eqname<<endl;
		}
};
int main()
{
	Character c1;
	c1.abilityname("Alian");
	c1.equipname("Gun");
	c1.charactername("Chandu");
	c1.display();
	return 0;
}
