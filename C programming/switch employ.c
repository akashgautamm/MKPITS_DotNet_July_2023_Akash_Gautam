#include<stdio.h>
void main()
{
	char name [20];
	char designation;
	int salary;
	printf("Enter Employee name:");
	scanf("%s",&name);
	printf("Enter designation(m,c,p)");
	fflush(stdin);
	scanf("%c",&designation);
	switch(designation)
	{
		case'm':
			salary=50000;
			break;
		case'c':
			salary=20000;
			break;
		case'p':
			salary=10000;
			break;
		default:
			printf("Invalid");
			break;
	}
	printf("\nemploye name=%s",name);
	printf("\nsalary=%d",salary);
}

//1.Start
//Accept name,designation.. int salary
//3. if designation is m then
//   3.1)salary=50000
//4. if designatio is c then
//   4.1)salary=20000
//5.if designation is p then
//   5.1)salarry=10000
//6.if designation is not between(m,c,p)
//  6.1printf("invalid")
//7. stop
