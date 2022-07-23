// Задача 71: В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». 
//Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита.
//n = 2 -> аа, ии, сс, вв, аи, иа, ис, си, ас, са, ав, ва, ви, ив, св, вс

Console.WriteLine("Задайте размер искомых слов: ");
int num = int.Parse(Console.ReadLine());
int n = 1;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (word.Length == length)
    {
        Console.WriteLine($"{n++} {new String(word)}");
        return;
    }

    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }

}
System.Console.WriteLine();
FindWords("аисв", new char[num]);

// Второй способ решения задачи.

// string charsWords = "аисв";
// int countCharsInWords = 2;
// string prefix = "";
// void PrintAllWords(string letters, int length, string prefix)
// {
//     if(length == 0) Console.Write(prefix + " ");
//     else
//     {
//         foreach(char sym in letters)
//         {
//             PrintAllWords(letters, length - 1, prefix + sym); 
//         }
//     }
// }

// PrintAllWords(charsWords, countCharsInWords, prefix);