#include <stdio.h>
void main()
{
	char n,g,e,m,f;
	int a;
	printf("Name\tAge\tGender\n");
	scanf("%c\t,%d\t,%c\t,\n",&n,&a,&g);
	if(a<21)
	{
		printf("it is eligible",a);
	}
	else
	{
		printf("it is not eligible");
	}
	
	
}
