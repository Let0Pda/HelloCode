/*======Работа с текстом
Дан текст. В тексте нужно все пробелы заменить черточками,
маленькие буквы "к" заменить большими "К",
а большие"С" заменить маленькими "с".

Ясна ли задача?
*/

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Выдадите мне чаю?";

// string s = "Текст"  ,    в частности если требуется обратиться к конкретному символу строки
//             01234        позиции отщитываются с "0"
// s[3]                     обратиться к опрееленному символу можно через "[]" скобки,  в конкретном случае "3" = "с"        
// string text - наш текст, char oldValue - символ который будем менять,  char newValue - символ на который будем менять
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    // Вывод строки результата с  инициализацией пустого значения строки "String.Empty"

    int length = text.Length;
    // Получаем длинну строки свойвство "text.Length" показывает кол-во символов в строке
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
Console.WriteLine($"Исходный текст: {text}");
Console.WriteLine();
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);