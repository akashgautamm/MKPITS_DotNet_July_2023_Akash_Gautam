#include<stdio.h>
#include<string.h>
struct book
{
	char title[50];
	char author[50];
	int bookid;
};
void printbook(struct book *ptr);
void main()
{
	struct book b1;
	printf("Title,Author,Bookid");
	scanf("%s%s%d",b1.title,b1.author,&b1.bookid);
	printbook(&b1);
}
void printbook(struct book *ptr)
{
	printf("\nTitle =%s",ptr->title);
	printf("\nAuthor=%s",ptr->author);
	printf("\nBookid=%d",ptr->bookid);
}
//1.Start
//2.Create struct book
//3.Declare int bookid,char title,author
//4.create void main
//5 print"title,author,bookid" from user
//6.call printbook
//7.Create void printbook(struct book*ptr)
//8.print "title,author,bookid"
//9.Stop


