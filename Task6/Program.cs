string text;

do
{
    Console.Write("Мәтінді енгізіңіз: ");
    text = Console.ReadLine() ?? "";
}
while (text == "");

int wordCount = CountWords(text);

Console.WriteLine($"Сөздер саны: {wordCount}");


// Мәтіндегі сөздердің санын есептеу әдісі
static int CountWords(string text)
{
    int count = 0;
    bool insideWord = false;

    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] != ' ')
        {
            if (!insideWord)
            {
                count++;
                insideWord = true;
            }
        }
        else
        {
            insideWord = false;
        }
    }

    return count;
}
