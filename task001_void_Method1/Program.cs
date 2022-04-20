/* Метод 1 Когда функция не принимает значение 
никаких аргументов и ничего не возвращает*/

/*Console.Clear();
void Method1()
{
    Console.WriteLine("Автор ...");
}
Method1();*/

/* Метод 2 Когда функция принимает значения, 
но ничего не возвращает*/
/*void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текстовое сообщение");*/

/*void Method21(string msg, int count)
{
    int i=0;
    while(i<count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg: "Текстовое сообщение", count: 4);
Method21(count: 4, msg: "Текстовое сообщение");*/

/* Метод 3 Когда функция не принимает значения, 
но при этом возвращает занчения аргумента*/
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

/* Метод 4 Когда функция и принимает значения, 
и при этом возвращает занчения аргумента*/

string Method4(int count, string text)
{
    int i=0;
    string result = String.Empty;

    while(i<count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "I Love logistics! ");
Console.WriteLine(res);