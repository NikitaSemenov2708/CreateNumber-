//## Консольная игра угадай число


//ПК загадал в некотором диапазоне число, например от 1 до 100
/* Далее он предлагает игроку угадать это число
Игрок вводит некоторое число
1. правильное это ли число
2. загаданное число больше чем введенное 
3. загаданное число меньше чем введенное 
После этого у игрок делает следующую догадку
У игрока есть некоторое количесвто попыток

Если игрок потратил все свои попытки игра заканчивается.
Если игрок угадал число но попытки еще остались игра также заканчивается */


/* 1.Диапазон мы задаем, формируем рандомно или запрашиваем у пользователя
Определится с количесвтом попыток, высчитать необходимое количесвто попыток, либо запросить у участника
2.Загадать число в указанном диапазоне
3. Начало игры описываем правила
4. Запрашиваем у пользователя некоторое число(добавить проверку в нештатных ситуаций)
Определяем как оно относится с нашим загаднным и даем следующие инструкции игроку
Если пользователь не угадал то сгорает одна попытка.
5. Игра продолжается пока есть попытки или пока пользователь не угадал число */

//int request () // Метод запросит у игрока число сделает все необходимые преоьразования и вернет это число
//int createnumber(int leftbond, int rightbound)// загадает число в указанном диапазоне и вернет его нам

//bool MakeMove(int secretnumber, int countofattemts)//- метод в котором запрограммирован 1 игровой ход, в результате метод возвращает либо true, либо fALSE, true если угадал и игру надо остановить
//false если не угадал

 /* string request()//запрашиваем диапазон
{

    Console.WriteLine("Введите нижний диапазон");
    int leftbond= int.Parse(Console.ReadLine());
    Console.WriteLine("Введите верхний диапазон");
    int rightbound= int.Parse(Console.ReadLine()); 
    string res= ($"Задан диапазон от {leftbond} до {rightbound}");
    return res;
   
}
string diapazon =request();
Console.WriteLine(diapazon);  */
// 1. int createnumber() Загадает число в указанном диапазоне и вернет его нам
// 2. int requestnumber() Запрашивает число у игрока
// 3. bool MakeMove(int secretnumber, int countofattemts)//- метод в котором запрограммирован 1 игровой ход, в результате метод возвращает либо true, либо fALSE, true если угадал и игру надо остановить
//false если не угадал



/* int createnumber(int leftbond, int rightbound) //Загадает число в указанном диапазоне и вернет его нам
{
    int number = new Random().Next(leftbond, rightbound);
    return number;
}

int requestnumber()
{
    string inputdata = string.Empty;
    bool conduction=true;
    do
    {
        inputdata= Console.ReadLine()!;
        conduction=(String.IsNullOrEmpty(inputdata))||!(Int32.TryParse(inputdata, out int outnumber)); // IsNullOrEmpty Указывает, является ли указанная строка пустой или пустой строкой (""). 
    } //TryParse Преобразует представление числа в виде диапазона в указанном стиле и формате, зависящем от языка и региональных параметров, в эквивалентное ему 32-битовое целое число со знаком. Возвращаемое значение указывает, успешно ли выполнено преобразование
    while (conduction);
    return Convert.ToInt32(inputdata); // ToInt32 Преобразует указанное логическое значение в эквивалентное 32-разрядное целое число со знаком.
    
}

int countAtempts =3;
int playersNumber =0;
int secretnumber = createnumber(1, 21);
Console.WriteLine(secretnumber);

do
{
    playersNumber = requestnumber();

    if (playersNumber==secretnumber)
    
    {
        Console.WriteLine("You are WIN");
        break;
    }
    else
    {
        countAtempts-=1;
        if (playersNumber>secretnumber)
        {
            Console.WriteLine("Загаданное число меньше вашего. Количество попыток: " + countAtempts);
        }
        else
        {
            Console.WriteLine("Загаданное число больше вашего. Количество попыток: " + countAtempts);
        }

    }
}while (countAtempts>0||playersNumber == secretnumber);
if (countAtempts==0)
{
    Console.WriteLine("Вы проиграли");
}


 */

/* int createnumber(int start, int finish)
{   
    int result = 0;
    result = new Random().Next(start, finish);
    return result;
}

int answernumber()
{   
    string inputdata= string.Empty;
    bool test = true;
    do
    {
    inputdata = Console.ReadLine()!;
    test = (String.IsNullOrEmpty(inputdata)||!(Int32.TryParse(inputdata, out int value)));
    } while (test);
    return Convert.ToInt32(inputdata);
}

int prob=3;
int playersNumber=0;

int secretnumber= createnumber(2, 5);
Console.WriteLine(secretnumber);

do
{
    playersNumber= answernumber();
    if (playersNumber==secretnumber)
    {
        Console.WriteLine("ВЫЙГРАЛ");
        break;
    }
    else
    {   
        prob-=1;
        if (playersNumber<secretnumber)
        {
            Console.WriteLine($"Число меньше загаданого, осталось попыток = {prob}");
        }
        else
        {
            Console.WriteLine($"Число больше загаданого, осталось попыток = {prob}");
        }
    }
} while (prob>0||playersNumber==secretnumber);

if (prob==0)
{
    Console.WriteLine("Вы проиграли");
}
 */


int createnumber(int start, int finish) // Метод загадывания числа компьютером
{   
    return new Random().Next(start, finish); 
}

int requestnumber() // Ввод и проверка числа введенного игроком
{
bool notexit = true;
string s= string.Empty;
while (notexit)
{
     Console.WriteLine("Введите число: ");
     s= Console.ReadLine()!;

     notexit=false;
     foreach (char c in s)
         if (!(c>='0' && c<='9'))
         {
             notexit=true;
             break;
         }
            if (notexit)
            Console.WriteLine("Ощибка ввода числа.Повторите ввод.");

}
return Int32.Parse(s);
}

bool MakeMove(int secretnumber, int countAtempts)
{
    int playersNumber = requestnumber();
    if (playersNumber==secretnumber)
    {
        Console.WriteLine($"Вы угадали число {secretnumber} и у Вас осталось {countAtempts} попыток");
        return true;
    }
    else
    {
        countAtempts--;
        if (countAtempts>0)
        {
            if (playersNumber>secretnumber)
            {
                Console.WriteLine($"Загаданное число меньше {playersNumber}");
            }
            else
            {
                Console.WriteLine($"Загаданное число больше {playersNumber}");
            }
            Console.WriteLine($"У вас осталось попыток {countAtempts}");
        }
        else
        Console.WriteLine("Попытки закончились");
        return false;
    }
}

void WriteRules(int min, int max, int count) // Описание правил
{
    Console.WriteLine("Компьютер загадал число от " + min + " до " + max);
    Console.WriteLine("Попробуйте угадать за " + count + " попыток ");
}

void Rungame()
{
    //настройка игры
    int minNum =1;
    int maxNum =100;
    int countofattemts=10; //задаем кол-во

    //подготовка игры
    int secretnumber = createnumber(minNum, maxNum);
    Console.WriteLine(secretnumber);
    WriteRules(minNum, maxNum, countofattemts);
    bool GameResult = false;

    //Основоное тело игры

    while (GameResult==false && countofattemts>0)
    {
         GameResult= MakeMove(secretnumber, countofattemts);
         countofattemts--;
    }

}

Rungame();