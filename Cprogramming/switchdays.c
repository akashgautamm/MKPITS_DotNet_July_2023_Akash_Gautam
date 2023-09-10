#include <stdio.h>
void main()
{
	int days_no;
	printf("Enter days no:");
	scanf("%d",&days_no);
	switch(days_no)
	{
		case 1:
			printf("Monday\n");
	     	break;
		case 2:
			printf("Tuesday\n");
		    break;
		case 3:
			printf("Wednesday\n");
		    break;
		case 4:
			printf("Thursday\n");
			break;
		case 5:
		    printf("Friday\n");
			break;
		case 6:
		    printf("Saturday\n");
			break;
		case 7:
		    printf("Sunday\n");
			break;
		default:
		    printf("Invalid days");	
	}
}

//1.Start
//2.Accept int days_no
//3.If day_no is 1 then,
//  3.1)print("monday")
//4.If day_no is 2 then,
//  4.1) print("Tuesday")
//5.Similarly check for other day no
//6.if day_no  between 1 to 7 then
//   6.1 printf (" invalid days")
  
