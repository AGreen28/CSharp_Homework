/*Задача 1: Задайте массив строк. Напишите программу,
считает кол-во слов в массиве, начинающихся на гласную букву.
Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1

int VowelsStart(string[] words)
{
    int count = 0;
    
    for(int i = 0; i < words.Length; i++)
    {
        if(words[i][0] == 'A' || words[i][0] == 'E' || words[i][0] == 'I' || words[i][0] == 'O' || words[i][0] == 'U' || words[i][0] == 'Y')
            count++;
    }
    return count;
}

string[] names = {"Alex", "Olga", "Dallas", "Anna", "Denis", "Max"};
Console.WriteLine(VowelsStart(names));
*/

/*Задача 2: Задайте массив строк. Напишите программу,
которая генерирует новый массив, объединяя элементы исходного массива попарно.
Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"}
*/

string[] words = {"aha", "hah", "aaa", "hhh", "agr", "agr"};

string[] DoubleWords(string[] words)
{
    string[] words2 = new string[words.Length / 2];
    for(int i = 0, j = 0; i < words.Length; i = i + 2, j++)
            words2[j] = words[i] + words[i + 1];
            
    return words2;
}

void PrintArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

PrintArray(DoubleWords(words));

