#include<stdio.h>
#include<string.h>
struct workers
{
	char name[20];
	int wage,wor,sal;
};
void main()
{
	struct workers wr[2];
	int wage,wor,sal;
	int counter;
	for(counter=0;counter<2;counter++)
	{
		printf("ENTER WORKER and WAGE and WORKING DAYS :");
		scanf("%s%d%d",&wr[counter].name,&wr[counter].wage,&wr[counter].wor);
	}
	for(counter=0;counter<2;counter++)
	{
		wr[counter].sal=wr[counter].wage*wr[counter].wor;
	}
	for(counter=0;counter<2;counter++)
	{
		printf("\nName =  %s\t",wr[counter].name);
		printf("Wages = %d\t",wr[counter].wage);
		printf("Working days = %d\t",wr[counter].wor);
		printf("total_sal = %d\t",wr[counter].sal);
	}
}
//1.Start
//2.Create struct worker
//3.Declare int wage,wor,salchar name
//4.Create void main
//5.Declare counter
//6.Check for loop counter=0 or counter<2
//7.print "worker,wage,working days"from user
//8.Check for loop counter=0 or counter<2
//9.formula sal=wage*working days
//10.Check for loop counter=0 or counter<1
//11.print "sal"
//12.Stop

