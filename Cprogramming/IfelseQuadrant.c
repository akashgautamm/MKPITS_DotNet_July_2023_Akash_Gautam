#include<stdio.h>
int main()
{
	int x,y;
	printf("Enter x and y\n");
	scanf("%d%d",&x,&y);
	
	if(x>0 && y>0)
	{
		printf("Co ordinates point are lies in First Quadrant");
	}
	else if(x<0 && y>0)
	{
		printf("Co ordinates point are lies in Second Quadrant");
	}
	else if(x<0 && y<0)
	{
		printf("Co ordinates point are lies in Third Quadrant");
	}
	else if(x>0 && y<0)
	{
		printf("Co ordinates point are lies in Fourth Quadrant");
	}
	
	
}
