#include<stdio.h>
#include<string.h>
struct student
{
	int rno;
	char name[20];
};
void main()
{
	struct student stud[5];
	int counter;
	for(counter=0;counter<5;counter++)
	{
		printf("Enter roll num and student name :");
		scanf("%d",&stud[counter].rno);
		scanf("%s",&stud[counter].name);
	}
	printf("\nStudent details:");
	for(counter=0;counter<5;counter++)
	{
		printf("\nRoll num=%d\t",stud[counter].rno);
		printf("\nStudent name=%s",stud[counter].name);
	}
	
}
//1.Start
//2.Create struct student
//3.Declare int rno char name
//4.Create void main
//5.Declare counter
//6.Check for loop counter=0 or counter<5
//7.print "roll num,student name"from user
//8.Check for loop counter=0 or counter<5
//9.print "roll num,student name"
//10.Stop

