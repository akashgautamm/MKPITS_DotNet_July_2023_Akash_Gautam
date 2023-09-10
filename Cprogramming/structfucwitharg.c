#include<stdio.h>
#include<string.h>
struct book
{
	char title[50];
	char author[50];
	int bookid;
};
void printbook(struct book b1);
void main()
{
	struct book b1;
	printf("Title , Author , Book id :");
	scanf("%s%s%d",b1.title,b1.author,&b1.bookid);
	printbook(b1);
}
void printbook(struct book b1)
{
	printf("\n Title = %s",b1.title);
	printf("\n Author =%s",b1.author);
	printf("\n Book id =%d",b1.bookid);
}
//1.Start
//2.Create struct book
//3.Declare int bookid,char title,author
//4.create void main
//5 print"title,author,bookid" from user
//6.Create void printbook
//7.print "title,author,bookid"
//8.Stop

