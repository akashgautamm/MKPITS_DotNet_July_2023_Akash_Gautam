#include<stdio.h>
#include<string.h>
struct cricket
{
	int run;
	char name[20];
};
void main()
{
	struct cricket cr[11];
	int counter;
	int total=0;
   	for(counter=0;counter<11;counter++)
    {
    	printf("ENTER PLAYER NAME and their RUNS :");
    	scanf("%s%d",&cr[counter].name,&cr[counter].run);
    }
    printf("\nEnter scorecard details :");
    for(counter=0;counter<11;counter++)
	{
		printf("\nName = %s\t",cr[counter].name);
		printf("Runs= %d\t",cr[counter].run);
		
	}
    for(counter=0;counter<11;counter++)
   	{
   		total=total+cr[counter].run;
   	}
   	printf("\nTotal runs of team = %d",total);
    
}
//1.Start
//2.Create struct cricket
//3.Declare int run,char name
//4.Create void main
//5.Declare counter,total=0
//6.Check for loop counter=0 or counter<11
//7.print "player name,runs"from user
//8.Check for loop counter=0 or counter<11
//9.formula total=total+cr[counter].run
//10.print "total"
//11.stop
