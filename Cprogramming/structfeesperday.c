#include<stdio.h>
#include<string.h>
struct fees
{
	char name[20];
	int fees,month,per_day;
};
void main()
{
	struct fees fe[3];
	int fees,month,hours,per_day,per_hrs;
	int counter;
	for(counter=0;counter<3;counter++)
	{
		printf("Enter name and Fess :");
		scanf("%s%d",fe[counter].name,&fe[counter].fees);
	}
	for(counter=0;counter<3;counter++)
	{
		month=20*5;
		hours=8;
		per_day=fe[counter].fees/month;
		per_hrs=per_day/8;
		printf("\nPer day = %d",per_day);
		printf("\nPer hrs =%d",per_hrs);
		
	}
	
}
//1.Start
//2.Create struct fees
//3.Declare int fees,month,perday,perhrs,hours,char name
//4.Create void main
//5.Declare counter
//6.Check for loop counter=0 or counter<3
//7.print "name,fees"from user
//8.Check for loop counter=0 or counter<3
//  8.1 month=20*5 use formu: perday=fees/month
//  8.2 hours=9   use perhrs=perday/8
//9.print "perdays,perhrs"
//10.print"sum"

