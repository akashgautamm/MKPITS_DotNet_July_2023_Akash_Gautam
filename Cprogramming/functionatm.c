#include<stdio.h>
void deposit(int amt,int bal);
void withdrawl(int amt,int bal);
void main()
{
	int bal=1000,amt;
	printf("Enter amount :");
	scanf("%d",&amt);
	deposit(amt,bal);
	withdrawl(amt,bal);
}
void deposit(int amt,int bal)
{
	bal=bal+amt;
	printf("Amount deposited = %d\n",bal);
}
void withdrawl(int amt,int bal)
{
	bal=bal-amt;
	printf("Amount withdrawl = %d \n",bal);
}
