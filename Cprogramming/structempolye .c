#include<stdio.h>
#include<string.h>
struct employee
{
	int sal;
	int id;
	char name[20];
	char desi[20];
	char dep[20];
};
void main()
{
	struct employee emp[5];
	int counter;
	for(counter=0;counter<5;counter++)
	{
		printf("Enter sal, id, name, desi, dep :");
		scanf("%d%d%s%s%s",&emp[counter].sal,&emp[counter].id,&emp[counter].name,&emp[counter].desi,&emp[counter].dep);
	}
	printf("\nEmpoyee details");
	for(counter=0;counter<5;counter++)
	{
		printf("\nSal = %d\t",emp[counter].sal);
		printf("id = %d\t",emp[counter].id);
		printf("name = %s\t",emp[counter].name);
		printf("desi = %s\t",emp[counter].desi);
		printf("dep = %s\t",emp[counter].dep);
		
	}

}
//1.Start
//2.Create struct employe
//3.Declare int sal,id,char desi,dep,name
//4.Create void main
//5.Declare counter
//6.Check for loop counter=0 or counter<5
//7.print "entersal,id,name,desi,dep"from user
//8.Check for loop counter=0 or counter<5
//9.print "sal,id,name,desi,dep"
//10.Stop

