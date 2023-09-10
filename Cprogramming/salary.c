#include <stdio.h>
void main()
{
	float basic,hra,da,total_sal;
	printf("Enter basic salary:");
	scanf("%f",&basic);
	hra=basic*0.35f;
	da=basic*0.45f;
	total_sal=basic+hra+da;
	printf("hra=%f\n",hra);
	printf("da=%f\n",da);
	printf("total salary=%f",total_sal);
}


