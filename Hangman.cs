
const bool DEBUG = true;
string[] WORD_LIST = new[] { "car", "cat", "dog", "elephant", "fish", "giraffe", "horse", "monkey", "panda", "sheep", "tiger", "zebra", "ant", "bee", "marmelade", "computer", "dax", "sjøbanan" };

int MAX_ATEMPTS = Graphics.HANGMAN_STATE_DRAWINGS.Length - 1;
int currentAtemptsAtGuessingWord = 0;
string word = PickRandomItemFromList(WORD_LIST);
string wordDisplay = CreateWordDisplay(word);
string currentDrawing = Graphics.HANGMAN_STATE_DRAWINGS[currentAtemptsAtGuessingWord];
bool isPlaying = true;

while (isPlaying)
{
    Clear();
    if (DEBUG)
    {
        Print($"Word : {word}");
    }
    Print($"Word : {wordDisplay}");
    Print(currentDrawing);
    Print("Guess a letter : ", newLine: false);

    char guess = ReadChar();
    if (word.Contains(guess))
    {
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == guess)
            {
                wordDisplay = wordDisplay.Remove(i, 1).Insert(i, guess.ToString());
            }
        }
    }
    else
    {
        currentAtemptsAtGuessingWord++;
        currentDrawing = Graphics.HANGMAN_STATE_DRAWINGS[currentAtemptsAtGuessingWord];
    }

    if (wordDisplay == word)
    {
        Clear();
        Print($"You won! The word was {word}");
        isPlaying = false;
    }
    else if (currentAtemptsAtGuessingWord == MAX_ATEMPTS)
    {
        Clear();
        Print($"You lost! The word was {word}");
        isPlaying = false;
    }
}

char ReadChar()
{
    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
    return keyInfo.KeyChar;
}

void Clear()
{
    Console.Clear();
}

void Print(string text, bool newLine = true)
{
    if (newLine)
    {
        Console.WriteLine(text);
    }
    else
    {
        Console.Write(text);
    }
}

string PickRandomItemFromList(string[] list)
{
    Random random = new Random();
    int randomIndex = random.Next(0, list.Length);
    return list[randomIndex];
}

string CreateWordDisplay(string word)
{
    string wordDisplay = "";
    for (int i = 0; i < word.Length; i++)
    {
        wordDisplay += "_";
    }
    return wordDisplay;
}