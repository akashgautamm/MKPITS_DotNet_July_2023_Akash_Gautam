#include<stdio.h>
#include<string.h>
struct book
{
	char title[50];
	char author[50];
	int bookid;
};
void main()
{
	struct book b1;
	strcpy(b1.title,"dot net");
	strcpy(b1.author,"ashish");
	b1.bookid=123;
	printf("\ntitle=%s",b1.title);
	printf("\nauthor=%s",b1.author);
	printf("\nbookid=%d",b1.bookid);
}
//1.Start
//2.Create struct book
//3.Declare int bookid,char title,author
//4.use strtcpy title=dotnet,author=ashish,bookid=123
//5 print"title,author,bookid"
//6.Stop

