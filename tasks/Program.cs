Console.WriteLine(@"Введите номер задачи:
1 - задача64;
2 - задача66;
3 - задача68;
4 - дополнительная задача1;");
string? answer = Console.ReadLine();
switch(answer){
    case "1": Task64(); break;
    case "2": Task66(); break;
    case "3": Task68(); break;
    case "4": starTask(); break;
    //case "5": doubleStarTask(); break;
    default: Console.WriteLine("Вы ввели неверное значение."); break;
} 

/*Задача 64: Задайте значения N и M. 
Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
*/
void Task64(){
    Console.WriteLine("Введите минимальное число промежутка двух чисел");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите максимальное число промежутка двух чисел");
    int N = Convert.ToInt32(Console.ReadLine());
    GetEvenNumber(M, N);

    void GetEvenNumber(int m, int n){
        if (m > n){
            Console.WriteLine("Вы задали неверно промежуток чисел");
            return;
        }
        string output = m % 2 == 0 ? m.ToString() : " ";
        Console.Write(output);
        if (m != n){            
            GetEvenNumber(m+1, n);
        } else return;
    }
}

/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
 натуральных элементов в промежутке от M до N с помощью рекурсии.*/

 void Task66(){
    Console.WriteLine("Введите минимальное число промежутка двух чисел");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите максимальное число промежутка двух чисел");
    int N = Convert.ToInt32(Console.ReadLine());
    int sum = GetSum(M, N);
    Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N} равна {sum}");

    int GetSum(int m, int n){
        if (m > n){
            Console.WriteLine("Вы задали неверно промежуток чисел");
            return 0;
        }
        if (m < n)
        return m + GetSum(m+1,n);
        else return n;
    }
 }

/*Задача 68: Задайте значения M и N. Напишите программу, 
которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.*/

void Task68(){
    Console.WriteLine("Введите первое число");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int N = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Наибольший общий делитель чисел {M} и {N} равен {GetNOD(M, N)}");
    
    //Использован Алгоритм Евклида
    int GetNOD(int m, int n){
        int r = m > n ? m % n : n % m;
        int q =  m > n ? n : m;
        if (r == 0) return  q;
        return GetNOD(q, r);
    }
}

/*Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.*/
void starTask(){
    Console.WriteLine("Введите первое число");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int N = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Функция Аккермана двух чисел {M} и {N} равна {GetAckerman(M, N)}");

    int GetAckerman(int m, int n)
    {
        if (m == 0) return n + 1;
        else if (m > 0 && n == 0) return GetAckerman(m - 1, 1);
        else return GetAckerman(m - 1, GetAckerman(m, n - 1));
    } 
}