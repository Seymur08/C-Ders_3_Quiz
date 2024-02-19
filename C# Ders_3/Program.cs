
ushort true_answer = 0;
void Screen(string[,] quiz, string[] variant, int next_quiz, int index)
{
    Console.Clear();

    Console.WriteLine($"True Answer    {true_answer}");
    Console.WriteLine();

    Console.WriteLine(quiz[next_quiz, 0]);


    for (int j = 1; j < 5; j++)
    {
        if (j - 1 == index)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[{variant[j - 1]}] {quiz[next_quiz, j]}");
            Console.ForegroundColor = ConsoleColor.White;

        }

        else Console.WriteLine($"[{variant[j - 1]}] {quiz[next_quiz, j]}");
    }

}


ushort index_var = 0;


string[,] quiz = new string[,]
{
        {"Bakinin Paytaxti Haradir","Gence","Baki","Seki","Merdekan","Baki" },
        {"CSharp Nedir ","Komputer","Prog dili","Bankomat","Ele bir sey yoxdur","Prog dili" },
        {"Titanik Necenci Ilde Batib","1915","1920","1912","1900","1912" },
        {"ilk superkomputer necenci ilde yaranib","1965","1985","1986","1975","1975" },
        {"ilk programlama dili ne zaman yaranib ","1949","1948","1945","1952","1945" },
        {"Amerikanin Paytaxti Haradir","Vasiqton","New-York","Cikago","Las-Vegas","Vasiqton" },
        {"Dunyani ilk Sensorlu telefon hansi sirket terefindan tapilib","IBM","Nokia","Motorola","Sony","IBM" },
        {"Everest Daginin Hundurluyu","10.234 m","7.786 m","5.456 m","8.849 m","8.849 m" },

};


string[] variant = { "A", "B", "C", "D" };
ushort index = 0;

int true_answer_size = 0;
int wrong_answer_size = 0;


int next_quiz = 0;

do
{

    string answer;

    switch (index_var)
    {
        case 0:
            Screen(quiz, variant, next_quiz, index_var);
            break;

        case 1:
            Screen(quiz, variant, next_quiz, index_var);
            break;

        case 2:
            Screen(quiz, variant, next_quiz, index_var);
            break;

        case 3:
            Screen(quiz, variant, next_quiz, index_var);
            break;
    }

    ConsoleKeyInfo info = Console.ReadKey(true);

    if (info.Key == ConsoleKey.Enter)
    {
        if (quiz[next_quiz, index_var + 1] == quiz[next_quiz, 5])
        {
            true_answer += 10;
            true_answer_size++;
        }

        else if (quiz[next_quiz, index_var + 1] != quiz[next_quiz, 5])
        {
            if (true_answer != 0)
            {
                true_answer -= 10;
                wrong_answer_size++;

            }
        }


        next_quiz++;
        index_var = 0;

    }


    if (info.Key == ConsoleKey.UpArrow)
    {
        if (index_var != 0)
            index_var--;
        else index_var = 3;
    }


    if (info.Key == ConsoleKey.DownArrow)
    {
        if (index_var != 3)
            index_var++;
        else index_var = 0;
    }

} while (next_quiz != 8);

Console.Clear();
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"You Score - {true_answer}");
Console.WriteLine($"Lost Point - {wrong_answer_size * 10}");
Console.WriteLine($"True Answer - {true_answer_size}");
Console.WriteLine($"Wrong Answer - {next_quiz - true_answer_size}");
Console.ForegroundColor = ConsoleColor.White;




