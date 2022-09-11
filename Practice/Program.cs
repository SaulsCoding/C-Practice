using Practice;
//Inheritance
Chef chef = new Chef();
chef.MakeSpecialDish();

ItalianChef italianchef = new ItalianChef();
italianchef.MakeSpecialDish();





//Static methods
/*Console.WriteLine(Math.Sqrt(144));
UsefulTools.SayHi("Mike");*/


//Static Attribute -  attribuye contains on the class it's self
/*Song holiday = new Song("Holiday", "Green Day", 200);
Console.WriteLine(Song.songCount);
Song kashmir = new Song("Kashmir", "Led Zeppelin", 1500);
Console.WriteLine(Song.songCount);



Console.WriteLine(kashmir.GetSongCount());*/


//Getter and Setters - TWO TYPES of methods that we can define in c#  classes - control access to attribute of those classes - make classes secure

/*Movie avengers = new Movie("The Avengers", "Joss Whedon", "dog");
Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");

Console.WriteLine(avengers.Rating);*/

//Object method
/*Student student1 = new Student("Jim", "Business", 2.8);
Student student2 = new Student("Joshua", "History", 3.6);

Console.WriteLine(student1.HasHonors());
Console.WriteLine(student2.HasHonors());*/

//Console.WriteLine(student1.name);

//Object - instance of a class
/*Book book1 = new Book("Harry Potter", "J.K Rollins", 400);
*//*book1.title = "Harry Potter";
book1.author = "J.K Rollins";
book1.pages = 400;*//*

Book book2 = new Book("Lord of The Rings", "Lord of The Rings", 700);
*//*book2.title = "Lord of The Rings";
book2.author = "Lord of The Rings";
book2.pages = 700;*//*

Console.WriteLine(book1.title);*/

/*try
{
    Console.WriteLine("Enter a number");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter another number");
    int num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(num1 / num2);
}
catch(DivideByZeroException e)
{
    Console.WriteLine(e.Message);
}
catch(FormatException e)
{
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine("Finally!!!");
}*/



/*int[,] numberGrid =
{
    { 1,2},
    {3,4 },
    {5,6 }
};
Console.WriteLine(numberGrid[2,1]);

int[,] myArray = new int[2, 3];
*/
/*static int GetPow(int baseNum, int powNum)
{
    int result = 1;
    for(int i = 0; i< powNum; i++)
    {
        result = result * baseNum;
    }
    return result;
}
Console.WriteLine(GetPow(3, 2));*/

/*int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
for(int i = 0; i < luckyNumbers.Length; i++)
{
    Console.WriteLine(luckyNumbers[i]);
}*/

/*int i = 1;
while (i <= 5)
{
    Console.WriteLine(i); 
    i++;
}
for(int a = 1; a <= 5; a++)
{
    Console.WriteLine(a);
}*/


//Guess Game
/*string secretWord = "giraffe";
string guess = "";
int guessCount = 0;
int guessLimit = 3;
bool outOfGuess = false;

while (guess != secretWord && !outOfGuess)
{
    if (guessCount < guessLimit)
    {
        Console.WriteLine("Enter guess");
        guess = Console.ReadLine();
        guessCount++;
    }
    else
    {
        outOfGuess = true;
    }   
}
if (outOfGuess)
{
    Console.WriteLine("You Lose!");
}
else
{
    Console.WriteLine("You Win!");
}
*/

/*do {
    Console.WriteLine("Enter guess");
    guess = Console.ReadLine();
    } while (guess != secretWord);
Console.WriteLine("You Win!");
*/
/*int index = 6;
do
{
    Console.WriteLine(index);
    index++;
} while (index <= 5);
*/
/*int index = 6;
while (index <= 5)
{
    Console.WriteLine(index);
    index++;
}*/

/*static string GetDay(int dayNum)
{
    
    //Switch statement
    string dayName;
    switch (dayNum)
    {
        case 0:
            dayName = "Sunday";
            break;
        case 1:
            dayName = "Monday";
            break;
        case 2:
            dayName = "Tuesday";
            break;
        case 3:
            dayName = "Wednesday";
            break;
        case 4:
            dayName = "Thursday";
            break;
        case 5:
            dayName = "Friday";
            break;
        case 6:
            dayName = "Saturday";
            break;
        default:
            dayName = "Invalid day number";
            break;
    }
    return dayName; 
}
Console.WriteLine(GetDay(15));*/

//Calculator
/*Console.Write("Enter a number: ");
decimal num1 = Convert.ToDecimal(Console.ReadLine());

Console.Write("Enter Operator : ");
string op = Console.ReadLine();

Console.Write("Enter a number: ");
decimal num2 = Convert.ToDecimal(Console.ReadLine());

if (op == "+")
{
    Console.Write(num1 + num2);
} else if (op == "-")
{
    Console.WriteLine(num1 - num2);
}
else if (op == "/")
{
    Console.WriteLine(num1 / num2);
}
else if (op == "*")
{
    Console.WriteLine(num1 * num2);
}
else
{
    Console.WriteLine("Invalid Operator");
}*/












/*static int GetMax(int num1, int num2, int num3)
{
    int result;
    if(num1 > num2 && num1 >= num3)
    {
        result = num1;
    }
    else if(num2 >= num1 && num2 >= num3)
    {
        result = num2;
    }else
    {
        result = num3;
    }

    return result;
}

Console.WriteLine(GetMax(20,1,15));*/




/*static void SayHi(string name, int age)
{
    Console.WriteLine($"Hello {name} and {age}");
}

SayHi("Mike", 24);
SayHi("Tom", 58);*/


/*static int cube(int num)
{
    int result = num * num * num;
    return result;
}
int cubeNumber = cube(5);

cube(5);
Console.WriteLine(cube(5));
Console.WriteLine(cubeNumber);*/

/*bool isMale = false;
bool isTall = true;

if (isMale || isTall)
{
    Console.WriteLine("You are a tall male");
}
else if (isMale && !isTall)
{

}else if (!isMale && isTall )
{

}else
{
    Console.WriteLine("You are not a Tall Male");
}*/

