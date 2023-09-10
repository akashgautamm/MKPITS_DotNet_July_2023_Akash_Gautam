#include<stdio.h>
int main()
{
	int n1,n2,n3,total;
	float per;
	printf("Enter 3 subject mark:\n");
	scanf("%d%d%d",&n1,&n2,&n3);
	total=n1+n2+n3;
	printf("total=%d\n",total);
	per=total/300.0f*100.0f;
	printf("per=%f\n",per);
	if(per>=75)
	{
		printf("grade=merrit");
	}
	else if(per>=60 && per<=75)
	{
		printf("grade=first\n");
	}
	else if(per>=40 && per<=60)
	{
		printf("grade=second\n");
	}
	else
	{
		printf(" fail");
	}
}

//1.Start
//2.Accept 3 subject mark,int n1,n2,n3 also total...float per
//3.Total mark n1+n+n3
//4.use formula, total/300.0f*100.0f
//5.Check wheather per is greater than or equal to 75
//  5.1)printf" grade is merrit"
//  5.2) Go to step 9
//6.Check wheather per is greater than or equal to 60 and per less than 75
//  6.1) printf" grade is first"
//  6.2) Go to step 9
//7.Check wheather per is greater than or equal to 40 and less tham 60
//  7.1)printf"grade is second"
//  7.2)Go to step 9
//8.printf " fail"
//9.stop
