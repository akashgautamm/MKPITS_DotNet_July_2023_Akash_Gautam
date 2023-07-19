#include <stdio.h>
void main()
{
	char customer_name[10], product_name[10];
	int quantity,price,discount,total_amount;
	printf("Enter customer name:");
	scanf("%s",&customer_name);
	printf("Enter product name:");
	scanf("%s",&product_name);
	printf("Enter price:");
	scanf("%d",&price);
	printf("Enter quantity:");
	scanf("%d",&quantity);
	total_amount=price*quantity;
	printf("total_amount=%d\n",total_amount);
	if(total_amount>=1000)
	{
		discount=total_amount*0.04;
		
	}
	else if(total_amount>=500)
	{
		discount=total_amount*0.05;
	
	}
	else
	{
		discount=total_amount*0.01;
		
	}
	printf("\ncustomer_name=%s",customer_name);
	printf("\nproduct_name=%s",product_name);
	printf("\nprice=%d",price);
	printf("\nquantity=%d",quantity);
	printf("\ndiscount=%d",discount);
	total_amount=total_amount - discount;
	printf("\ntotal amount=%d",total_amount);
}

//1.Start
//2.Accept customer_name,product_name,quantity,price,discount,total_amount
//3.Formula for total amount=price*quantity
//4.If total_amount greater than 10000 so,
//  4.1Formula discount=total_amount*0.04
//5.If total amount greater than or equal to 500 so,
//  5.1 Formula discount=total_amount*0.05
//6.Else.. formula discount=total_amount*0.01
//7 Then print customer_name,product_name,price,quantity,discount,total_amount
//8.Stop

