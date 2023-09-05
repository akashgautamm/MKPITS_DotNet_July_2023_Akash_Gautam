#include<iostream>
using namespace std;
class Ability
{
	private:
		string abiname;
	public:
		void abilityname(string an)
		{
			abiname=an;
		}
		void displaya()
		{
			cout<<"Ability name="<<abiname<<endl;
		}
};
class Equipment
{
	private:
		string eqname;
	public:
		void equipname(string ei)
		{
			eqname=ei;
		}
		void displaye()
		{
			cout<<"Equip name="<<eqname<<endl;
		}
};
class Character:public Ability,public Equipment
{
	private:
		string character;
	public:
		void charactername(string ch,string an,string ei)
		{
			character=ch;
			abilityname(an);
			equipname(ei);
		}
		void displayc()
		{
			cout<<"Char name="<<character<<endl;
			Ability::displaya();
			Equipment::displaye();
		}
};
int main()
{
	Character c1;
	c1.charactername("Snake","gun","Akash");
	c1.displayc();
	return 0;
}
