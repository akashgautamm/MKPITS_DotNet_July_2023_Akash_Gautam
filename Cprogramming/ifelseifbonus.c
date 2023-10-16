

#include<stdio.h>
void main()
{
	char name[10];
	int salary,bonus=0;
	printf("Enter name:");
	scanf("%s",&name);
	printf("Enter salary:");
	scanf("%d",&salary);
	if(salary>=10000)
	{
		bonus=5000;
	}
	else if(salary>=5000 && salary<10000)
	{
		bonus=2000;
	}
	else
	{
		bonus=1000;
	}
	printf("Employe name=%s\n",name);
	printf("salary=%d\n",salary);
	printf("bonus=%d\n",bonus);
} 

//1.Start
//2.Accept int salary,bonus=0.. char name[10]
//3.Check wheather if salary is greater than or equal to 10000
//  3.1 bonus=5000
//4.Check wheather if salary 5000 is greater or equal to and salary is less than 10000
//  4.1 bonus=2000
//  4.2 Go to step 9
//5.else, bonus=1000
//6.printf " name"
//7.printf"salary"
//8.printf"bonus"
//9.Stop
