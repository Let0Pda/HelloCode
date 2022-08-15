// Основные группы методов:
// 1. Ничего не принимает, ничего не возвращает (void)

void Method1()
{
    Console.WriteLine("Автор...");
}
//Method1(); // () скобки ОБЯЗАТЕЛЬНЫ!

// 2. Что-то принимает, ни чего не возвращвет

void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("Текст сообщения"); // Общий вызов
//Method2(msg: "Именованый аргумент"); // вызов (msg) именнованного аргумента

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++; // Увеличение на единицу называют инкриментом, а уменьшение на единицу декриментом  
    }
}
//Method21("Текст", 4); // ("",4) Сколько раз мы хотим увидет вывод ...
//Method21(msg: "Новый текст", count: 4); // Можем ЯВНО указывать какому аргументу какое значение мы хотим присвоить, такой конструкцией
//Method21(count: 4, msg: "Новый текст"); // При использовании именнованных аргументов порядок написания выводароли не играет

// 3. Ничего не принимает, что-то возвращает (например: служат для генерации случайных данных)

int Method3()
{
    return DateTime.Now.Year;  // В данном варианте (return) ОБЯЗАТЕЛЕН , т.к должен что-то возвращать
}
int year = Method3();
//Console.WriteLine(year);

/* 4.  Что-то принимают, что-то возвращают
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "Bb ");
Console.WriteLine(res);
*/

// 5. Цикл (for), цыкл СО СЧЕТЧИКОМ  просто в себе собирает все в "Кучу", все в одном месте

string Method5(int count, string text)
{

    string result = String.Empty;
    for (int i = 0; i < count; i++)

    {
        result = result + text;
    }
    return result;
}
string res = Method5(10, "Bb ");
//Console.WriteLine(res);

// 6. Использование цикла в цикле, пример: вывод таблицы умножения


for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i}x{j} ={i * j}");
    }
    Console.WriteLine();
}