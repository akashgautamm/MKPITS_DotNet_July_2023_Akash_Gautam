//Intialization od 2d array....
#include<stdio.h>
void main()
{
	int arr[2][2]={{1,2},{3,4}};
	int row,col;
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			printf("arr[%d][%d]=%d\n",row,col,arr[row][col]);
		}
	}
}
//1.Start
//2.Declare arr[2][2]={{1,2},{3,4}} intialize also int row,col
//3.Check for row=0;row<2;row++
//4.Check for col=0;col<2;col++
//  4.1 print row,col,arr[row],[col]
//5. Stop
