// See https://aka.ms/new-console-template for more information

using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using System.Xml.Linq;
using WSUniversalLib;



Console.Write("Введите колличество:");
int count = int.Parse(Console.ReadLine());
Console.Write("Введите ширину:");
int widht = int.Parse(Console.ReadLine());
Console.Write("Введите длину:");
int height = int.Parse(Console.ReadLine());
Console.Write("Введите тип продукции:");
int ProdType = int.Parse(Console.ReadLine());
Console.Write("Введите тип материала:");
int MaterialType = int.Parse(Console.ReadLine());



Calc c = new Calc();
int rez = Calc.GetQuaForProd(count, widht, height, ProdType, MaterialType);
Console.Write("Результат: " + rez);























