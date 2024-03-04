using Sealed_Struct_Nullable_Enum;
using Sealed_Struct_Nullable_Enum.Helpers.Extensions;
using Sealed_Struct_Nullable_Enum.Services;

//string email = "fatime@gmail.com";

//if (email.CheckStr('@'))
//{
//    Console.WriteLine("yes");
//}
//else
//{
//    Console.WriteLine("no");
//}

//string pass = "asaddasdafs";

//Console.WriteLine(pass.CheckPasswordLength());


//string str = "salam23";

//Console.WriteLine(str.CheckTextWithRegex(@"\d"));

//Console.WriteLine(str.CheckTextWithRegex(@"[A-Za-z]"));

//int[] nums = { 1, 3, 5, 6, };

//Console.WriteLine(nums.MultiplyArrayItems());


//Console.WriteLine("Add number 1");
//string num1 = Console.ReadLine();

//Console.WriteLine("Choose one operation: +, -, *, / ");
//string operation = Console.ReadLine();

//Console.WriteLine("Add number 2");
//string num2 = Console.ReadLine();

//CalculatorService service = new();

//string response = service.Calculation(Convert.ToDouble(num1), operation, Convert.ToDouble(num2));

//Console.WriteLine(response);



Book book = new Book();

//book.Name = "sadsd";
//Console.WriteLine(book.Name);

//int num = 5;

//Class1 class1= new Class1();

//class1.MyProperty = 100;

//Console.WriteLine(class1.MyProperty);

string name = null;

//int? num = null;

//Console.WriteLine(book.Id);

//if (book.Id == null)
//{
//    Console.WriteLine("Book id notfound");
//}

//Book book1 = new()
//{
//    Id = 1,
//    Name = "Isgendername",
//    Author = new Author() { Name = "Nizami", Id = 2 },

//};

//Book book1 = new()
//{
//    Id = 1,
//    Name = "Isgendername",
//    Author = new Author() { Id = 2 },

//};

//Book book2 = new()
//{
//    Id = 2,
//    Name = "Xosrov ve Shirin"
//};

//Console.WriteLine("Book: " + book1.Name + "   Author: " + book1.Author.Name?.Substring(1, 3));

//Book[] books = { book1, book2 };

//void GetBookById(Book[] books, int? id = null)
//{
//    if (id == null)
//    {
//        Console.WriteLine("Your id is null");
//        return;
//    }

//    Book result = books.FirstOrDefault(m => m.Id == id);

//    Console.WriteLine(result?.Name);

//    string? name = null;
//}

//GetBookById(books, 2);



Level level = Level.High;

//Console.WriteLine(level);

//Console.WriteLine((int)level == 1);

//void GetLevel(int levelNum)
//{
//    switch (levelNum)
//    {
//        case (int)Level.Low:
//            Console.WriteLine("Low");
//            break;
//        case (int)Level.Medium:
//            Console.WriteLine("Medium");
//            break;
//        case (int)Level.High:
//            Console.WriteLine("High");
//            break;
//        default:
//            break;
//    }
//}

//void GetLevel(Level levelNum)
//{
//    switch (levelNum)
//    {
//        case Level.Low:
//            Console.WriteLine("Low");
//            break;
//        case Level.Medium:
//            Console.WriteLine("Medium");
//            break;
//        case Level.High:
//            Console.WriteLine("High");
//            break;
//        default:
//            break;
//    }
//}

void GetLevel(string level)
{
    switch (level)
    {
        case nameof(Level.Low):
            Console.WriteLine("Low");
            break;
        case nameof(Level.Medium):
            Console.WriteLine("Medium");
            break;
        case nameof(Level.High):
            Console.WriteLine("High");
            break;
        default:
            Console.WriteLine("Telefonu yerine qoyun Elmir bey");
            break;
    }
}

//GetLevel("High");