#region Q1
using System.Text;

string title = "clean code";
string upperTitle = title.ToUpper();
Console.WriteLine(title);
Console.WriteLine(upperTitle);
#endregion

#region Q2
string a = "clean code";
string b = "clean code";
Console.WriteLine(ReferenceEquals(a, b));
#endregion

#region Q3,4
//Q3
StringBuilder x = new StringBuilder();
x.Append("book list");
x.Append(" - updated");
Console.WriteLine(x.ToString());

//Q4
x.Replace("book list", "library");
Console.WriteLine(x.ToString());
#endregion

#region Q5,6,7
string title1 = "clean code";
int pages = 464;
//book: clean code ,pages: 464

//Q5
string s1 = "book: " + title1 + ", pages: " + pages;

//Q6
string s2 = $"Book: {title1}, Pages: {pages}";

//Q7
string s3 = string.Format("Book: {0}, Pages: {1}", title1, pages);

Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);
#endregion

#region Q8
int pages1 = 464;
if (pages1 > 300)
{
    Console.WriteLine("long book");
}
else
{
    Console.WriteLine("short book");
}
#endregion

#region Q9
int pages2 = 464;
bool isAvailable = true;

if(pages2 > 300 && isAvailable == true)
{
    Console.WriteLine("you can borrow this book");
}
#endregion

#region Q10
string title2 = "refactoring";
switch (title2)
{
    case "clean code":
        Console.WriteLine("great choice!");
        break;

    case "refactoring":
        Console.WriteLine("nice pick!");
        break;

    default:
        Console.WriteLine("never heard of it");
        break;
}
#endregion

#region Q11
int pages3 = 464;
string sizeLabel = pages3 > 300 ? "long book" : "short book";
Console.WriteLine(sizeLabel);
#endregion

#region Q12
string[] books = { "clean code", "the pragmatic programmer", "refactoring" };
int i = 0;

for ( ; i < books.Length; i++)
{
    Console.WriteLine($" {i + 1} . {books[i]} ");
}

#endregion

#region Q13
//array in Q12
int I = 0;
while (I < books.Length)
{
    Console.WriteLine(books[I]);
    I++;
}
#endregion

#region Q14
int count = 0;
do
{
    Console.WriteLine("checking book");
    count++;
}
while (count < 3);
#endregion

#region Q15
//array in Q12

foreach (string book in books)
{
    Console.WriteLine(book);
}
#endregion

#region 16
//array in Q12
for (i=0; i < books.Length; i++)
{
    if (books[i] == "refactoring")
    {
        break;
    }
    Console.WriteLine(books[i]);
}
#endregion

#region Q17
//array in Q12
for (i = 0; i < books.Length; i++)
{
    if (books[i] == "the pragmatic programmer")
    {
        continue;
    }
    Console.WriteLine(books[i]);
}
#endregion

#region Q18
//????
#endregion