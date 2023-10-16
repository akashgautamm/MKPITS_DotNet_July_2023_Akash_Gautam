#include <stdio.h>
int main()
{
	char names[20];
	int id,unit,total;
	printf("Enter name");
	scanf("%s",&names);
	printf("Enter Id");
	scanf("%d",&id);
	printf("Enter unit");
	scanf("%d",&unit);
	
	
	if(unit<100)
	{
		total=unit*1;
	}
	else if(unit>100 && unit<200)
	{
		total=unit*2;
		
	}
	else
	{
		total=unit*3;
	}
	printf("Name is =%s\n",names);
	printf("Id is = %d\n",id);
	printf("Unit consume is =%d\n",unit);
	printf("Total Bill is =%d\n",total);
}
