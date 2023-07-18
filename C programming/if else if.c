#include<stdio.h>
int main()
{
	int n1,n2,n3;
	printf("Enter 3 no:\n");
	scanf("%d%d%d",&n1,&n2,&n3);
	if(n1>n2 && n1>n3)
	{
		printf("n1 is greater");
	}
	else if(n2>n3)
	{
		printf("n2 is greater");
	}
	else
	{
		printf("n3 is greater");
	}
	return 0;
}

//1.Start
//2.Accept three num. int num1,num2,num3
//3.Check num1 is greater than num2,num1 is greater than num3,if yes
//   3.1)printf "num1 is greater
//   3.2)Go to step 6 
//4.Check num2 is greater num3
//   4.1)printf "num2 is greater
//   4.2)Go to step 6
//5.printf "num3 is greater
//6.Stop
