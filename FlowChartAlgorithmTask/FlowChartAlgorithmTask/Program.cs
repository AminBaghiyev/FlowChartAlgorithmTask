// UTF-8 Support
using System.Text;
Console.OutputEncoding = Encoding.Unicode;

#region Task-1
// Verilmiş 3 rəqəmli ədədin rəqəmlərinin cəminin cüt olub-olmamasının tapılması.

Console.Write("Üçrəqəmli ədəd daxil edin: ");
int taskOneNum = int.Parse(Console.ReadLine());
int taskOneSumOfDigits = taskOneNum / 100 + taskOneNum / 10 % 10 + taskOneNum % 10;
if (taskOneSumOfDigits % 2 == 0)
{
    Console.WriteLine($"{taskOneNum} ədədinin rəqəmləri cəmi cütdür! Cəmi: {taskOneSumOfDigits}");
}
else
{
    Console.WriteLine($"{taskOneNum} ədədinin rəqəmləri cəmi təkdir! Cəmi: {taskOneSumOfDigits}");
}
#endregion

#region Task-2
// Verilmiş 4 rəqəmli ədədin rəqəmlərinin ədədi ortasını tapılması.

Console.Write("Dördrəqəmli ədəd daxil edin: ");
int taskTwoNum = int.Parse(Console.ReadLine());
float numericalAverage = (taskTwoNum / 1000 + taskTwoNum / 100 % 10 + taskTwoNum / 10 % 10 + taskTwoNum % 10) / 4f;
Console.WriteLine($"{taskTwoNum} ədədinin rəqəmləri cəminin ədədi ortası: {numericalAverage}");
#endregion

#region Task-3
// Verilmiş 3 rəqəmli ədədin rəqəmləri cəminin 3-ə və 5-ə bölünüb-bölünmədiyinin tapılması.

Console.Write("Üçrəqəmli ədəd daxil edin: ");
int taskThreeNum = int.Parse(Console.ReadLine());
int taskThreeSumOfDigits = taskThreeNum / 100 + taskThreeNum / 10 % 10 + taskThreeNum % 10;
string taskThreeOutput = "";
if (taskThreeSumOfDigits % 3 == 0)
{
    taskThreeOutput += "3'ə";
}
if (taskThreeSumOfDigits % 5 == 0)
{
    taskThreeOutput += (taskThreeOutput.Length > 0 ? " və " : "") + "5'ə";
}

if (taskThreeOutput.Length > 0)
{
    Console.WriteLine($"{taskThreeNum} ədədinin rəqəmləri cəmi {taskThreeOutput} bölünür.");
}
else
{
    Console.WriteLine($"{taskThreeNum} ədədinin rəqəmləri cəmi 3'ə və 5'ə bölünmür.");
}
#endregion

#region Task-4
// Verilmiş tələbə balına uyğun olaraq semestr nəticəsinin tapılması. (məs: 90 => B , 50 => F(Kəsr))

Console.Write("Balınızı daxil edin: ");
float gpa = float.Parse(Console.ReadLine());
switch (gpa)
{
    case float g when g >= 91 && g <= 100:
        Console.WriteLine("Dərəcə: A");
        break;
    case float g when g >= 81 && g <= 90:
        Console.WriteLine("Dərəcə: B");
        break;
    case float g when g >= 71 && g <= 80:
        Console.WriteLine("Dərəcə: C");
        break;
    case float g when g >= 61 && g <= 70:
        Console.WriteLine("Dərəcə: D");
        break;
    case float g when g >= 51 && g <= 60:
        Console.WriteLine("Dərəcə: E");
        break;
    default:
        Console.WriteLine("Dərəcə: F");
        break;
}
#endregion

#region Task-5
// Verilmiş 2 ədədin yoxlanışı. Əgər ədədlərdən hər ikisi də cüt ədəd olarsa cəmini, heç olmasa biri tək olarsa fərqini tapın.

Console.Write("İlk ədədi daxil edin: ");
int taskFiveFirstNumber = int.Parse(Console.ReadLine());
Console.Write("İkinci ədədi daxil edin: ");
int taskFiveSecondNumber = int.Parse(Console.ReadLine());
if (taskFiveFirstNumber % 2 == 0 && taskFiveSecondNumber % 2 == 0)
{
    Console.WriteLine($"Ədədlər cütdür. Cəmləri: {taskFiveFirstNumber + taskFiveSecondNumber}");
}
else
{
    Console.WriteLine($"{(taskFiveFirstNumber % 2 != 0 ? taskFiveFirstNumber : taskFiveSecondNumber)} təkdir. Fərqləri: {taskFiveFirstNumber - taskFiveSecondNumber}");
}
#endregion

#region Task-6
// Verilmiş 2 dəyişəndən 1-i işçinin maaşını digəri isə bank-dan götürmək istədiyi krediti göstərir edir.
// Əgər işçinin kredit götürmək istədiyi məbləğ illik gəlirinin 60 faizindən çox olarsa sorğunun uğursuz olduğu ekrana çıxsın əks təqdirdə prosesin uğurlu şəkildə həyata keçdiyi yazılsın.

Console.Write("Aylıq maaşınızı daxil edin: ");
float salary = float.Parse(Console.ReadLine());
Console.Write("Kredit götürmək istədiyiniz məbləği daxil edin: ");
float credit = float.Parse(Console.ReadLine());
if (credit <= salary * 12 * 6 / 10)
{
    Console.WriteLine("Sizə kredit düşür.");
} else
{
    Console.WriteLine("Sizə kredit düşmür.");
}
#endregion