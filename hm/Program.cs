using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    public class Boris { }
    class Rashid : Boris { } //finance director
    class Lukas : Rashid { }
    class Buh : Lukas { }
    class OIlham : Boris { } // automatisation director
    class Orcadiy : OIlham { }
    class Volodya : Orcadiy { }
    class Ilshat : Volodya { } // system
    class Ivanich : Ilshat { }
    class Ilya : Ivanich { }
    class Vitya : Ivanich { }
    class Jeka : Ivanich { }
    class Sergey : Volodya { }// development
    class Lyaisan : Sergey { }
    class Marat : Lyaisan { }
    class Dina : Lyaisan { }
    class Ildar : Lyaisan { }
    class Anton : Lyaisan { }
    internal class Program
    {
        static void Otvet(Type a, Type b)
        {
            if (a.IsSubclassOf(b)) { Console.WriteLine("Yes"); } // проверяем является ли классы наследниками друг друга
            else { Console.WriteLine("No"); }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите от кого хотите дать задачу (лат.)");
            string A1 = Console.ReadLine();
            Console.WriteLine("Введите кому хотите дать задачу (лат.)");
            string B1 = Console.ReadLine();
            Console.WriteLine("Введите название задачи");
            string C1 = Console.ReadLine();
            Type A = Type.GetType("HW" + "." + A1, false, true); // получаем типы классов по имени(строке)
            Type B = Type.GetType("HW" + "." + B1, false, true);
            Console.WriteLine($"Итак, от {A1} дана задача {C1}  для {B1}.");
            Console.WriteLine("Ответ сотрудника:");
            Otvet(B, A);
        }
    }
}

