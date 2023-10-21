

string[] menuItems = new string[] { "Форма Торта", "Вкус", "Размер", "Кол-во коржей", "Глазурь", "Декор", "Конец Заказа" };
string[] formtorta = new string[] { "Квадрат", "Сердце", "Круг" };
int[] priceformtorta = new int[] { 500, 700, 500 };
string[] vcus = new string[] { "Шоколадный", "Ягодный", "Мусовый" };
int[] pricevcus = new int[] { 500, 700, 700 };
string[] size = new string[] { "12 см ", "24 см", "32 см" };
int[] pricesize = new int[] { 500, 700, 800 };
string[] korg = new string[] { "1 коржа", "3 коржа", "4 коржа" };
int[] pricekorg = new int[] { 500, 700, 900 };
string[] glasur = new string[] { "шоколад", "крем", "драже" };
int[] priceglasur = new int[] { 500, 700, 500 };
string[] decor = new string[] { "Шоколадный лебедь", "Кровать", "Дио!" };
int[] pricedecor = new int[] { 10000, 700, 500 };


int row = Console.CursorTop;
int col = Console.CursorLeft;
ConsoleKeyInfo k;
ConsoleKeyInfo k2;
int index = 0;
int index2 = 0;
int cena = 0;
int flag = 0;
int flag2 = 0;
string tort = null;
do
{
    if (flag2 == 0)
    {
        Console.WriteLine(" Выберите параметр:");
    }
    flag2 = 1;


    DrawMenu(menuItems, row + 3, col, index);
    Console.WriteLine("Цена:" + cena);
    Console.WriteLine("Ваш торт:" + tort);
    k = Console.ReadKey();

    switch (k.Key)
    {
        case ConsoleKey.DownArrow:
            if (index < menuItems.Length - 1)
                index++;
            break;
        case ConsoleKey.UpArrow:
            if (index > 0)
                index--;
            break;
        case ConsoleKey.Enter:
            switch (index)
            {
                case 0:
                    Console.Clear();
                    index2 = 0;
                    flag = 0;
                    do
                    {
                        if (flag == 0)
                        {
                            Console.WriteLine("Для выхода нажмите escape");
                            Console.WriteLine("Выберите пункт из меню");
                            Console.WriteLine("----------------------");
                        }
                        flag = 1;

                        DrawMenu2(formtorta, priceformtorta, row + 3, col, index2);
                        k2 = Console.ReadKey();
                        switch (k2.Key)
                        {
                            case ConsoleKey.DownArrow:
                                if (index2 < formtorta.Length - 1)
                                    index2++;
                                break;
                            case ConsoleKey.UpArrow:
                                if (index2 > 0)
                                    index2--;
                                break;
                            case ConsoleKey.Enter:
                                cena += priceformtorta[index2];
                                tort = tort + formtorta[index2] + " - " + priceformtorta[index2] + ";";
                                break;
                        }
                    }
                    while (k2.Key != ConsoleKey.Escape);
                    flag2 = 0;
                    Console.Clear();
                    break;
                case 1:
                    Console.Clear();
                    index2 = 0;
                    flag = 0;
                    do
                    {
                        if (flag == 0)
                        {
                            Console.WriteLine("Для выхода нажмите escape");
                            Console.WriteLine("Выберите пункт из меню");
                            Console.WriteLine("----------------------");
                        }
                        flag = 1;
                        DrawMenu2(vcus, pricevcus, row + 3, col, index2);
                        k2 = Console.ReadKey();
                        switch (k2.Key)
                        {
                            case ConsoleKey.DownArrow:
                                if (index2 < vcus.Length - 1)
                                    index2++;
                                break;
                            case ConsoleKey.UpArrow:
                                if (index2 > 0)
                                    index2--;
                                break;
                            case ConsoleKey.Enter:
                                cena += pricevcus[index2];
                                tort = tort + vcus[index2] + " - " + pricevcus[index2] + ";";
                                break;

                        }
                    }
                    while (k2.Key != ConsoleKey.Escape);
                    flag2 = 0;
                    Console.Clear();
                    break;
                case 2:
                    Console.Clear();
                    index2 = 0;
                    flag = 0;
                    do
                    {
                        if (flag == 0)
                        {
                            Console.WriteLine("Для выхода нажмите escape");
                            Console.WriteLine("Выберите пункт из меню");
                            Console.WriteLine("----------------------");
                        }
                        flag = 1;
                        DrawMenu2(size, pricesize, row + 3, col, index2);
                        k2 = Console.ReadKey();
                        switch (k2.Key)
                        {
                            case ConsoleKey.DownArrow:
                                if (index2 < size.Length - 1)
                                    index2++;
                                break;
                            case ConsoleKey.UpArrow:
                                if (index2 > 0)
                                    index2--;
                                break;
                            case ConsoleKey.Enter:
                                cena += pricesize[index2];
                                tort = tort + size[index2] + " - " + pricesize[index2] + ";";
                                break;
                        }
                    }
                    while (k2.Key != ConsoleKey.Escape);
                    flag2 = 0;
                    Console.Clear();
                    break;
                case 3:
                    Console.Clear();
                    index2 = 0;
                    flag = 0;
                    do
                    {
                        if (flag == 0)
                        {
                            Console.WriteLine("Для выхода нажмите escape");
                            Console.WriteLine("Выберите пункт из меню");
                            Console.WriteLine("----------------------");
                        }
                        flag = 1;
                        DrawMenu2(korg, pricekorg, row + 3, col, index2);
                        k2 = Console.ReadKey();
                        switch (k2.Key)
                        {
                            case ConsoleKey.DownArrow:
                                if (index2 < korg.Length - 1)
                                    index2++;
                                break;
                            case ConsoleKey.UpArrow:
                                if (index2 > 0)
                                    index2--;
                                break;
                            case ConsoleKey.Enter:
                                cena += pricekorg[index2];
                                tort = tort + korg[index2] + " - " + pricekorg[index2] + ";";
                                break;
                        }
                    }
                    while (k2.Key != ConsoleKey.Escape);
                    flag2 = 0;
                    Console.Clear();
                    break;
                case 5:
                    Console.Clear();
                    index2 = 0;
                    flag = 0;
                    do
                    {
                        if (flag == 0)
                        {
                            Console.WriteLine("Для выхода нажмите escape");
                            Console.WriteLine("Выберите пункт из меню");
                            Console.WriteLine("----------------------");
                        }
                        flag = 1;
                        DrawMenu2(decor, pricedecor, row + 3, col, index2);
                        k2 = Console.ReadKey();
                        switch (k2.Key)
                        {
                            case ConsoleKey.DownArrow:
                                if (index2 < formtorta.Length - 1)
                                    index2++;
                                break;
                            case ConsoleKey.UpArrow:
                                if (index2 > 0)
                                    index2--;
                                break;
                            case ConsoleKey.Enter:
                                cena += pricedecor[index2];
                                tort = tort + decor[index2] + " - " + pricedecor[index2] + ";";
                                break;
                        }
                    }
                    while (k2.Key != ConsoleKey.Escape);
                    flag2 = 0;
                    Console.Clear();
                    break;
                case 4:
                    Console.Clear();
                    index2 = 0;
                    flag = 0;
                    do
                    {
                        if (flag == 0)
                        {
                            Console.WriteLine("Для выхода нажмите escape");
                            Console.WriteLine("Выберите пункт из меню");
                            Console.WriteLine("----------------------");
                        }
                        flag = 1;
                        DrawMenu2(glasur, priceglasur, row + 3, col, index2);
                        k2 = Console.ReadKey();
                        switch (k2.Key)
                        {
                            case ConsoleKey.DownArrow:
                                if (index2 < glasur.Length - 1)
                                    index2++;
                                break;
                            case ConsoleKey.UpArrow:
                                if (index2 > 0)
                                    index2--;
                                break;
                            case ConsoleKey.Enter:
                                cena += priceglasur[index2];
                                tort = tort + glasur[index2] + " - " + priceglasur[index2] + ";";
                                break;
                        }
                    }
                    while (k2.Key != ConsoleKey.Escape);
                    flag2 = 0;
                    Console.Clear();
                    break;
                case 6:
                    try
                    {

                        StreamWriter sw = new StreamWriter("D:\\Test.txt", true);
                        sw.WriteLine("Заказ от " + DateTime.Now);

                        sw.WriteLine(tort);
                        sw.WriteLine("Цена: " + cena);

                        sw.Close();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception: " + e.Message);
                    }
                    finally
                    {
                        Console.WriteLine("Executing finally block.");
                    }
                    cena = 0;
                    tort = null;
                    flag2 = 0;
                    Console.Clear();
                    break;
                default:
                    break;
            }
            break;
    }
}
while (k.Key != ConsoleKey.Escape);
void DrawMenu(string[] items, int row, int col, int index)
{
    Console.SetCursorPosition(col, row);
    for (int i = 0; i < items.Length; i++)
    {
        if (i == index)
        {
            if (i != items.Length - 1)
            {
                Console.WriteLine("->" + (i + 1) + ". " + items[i]);
            }
            else
            {
                Console.WriteLine("->" + items[i]);
            }
        }
        else
        {
            if (i != items.Length - 1)
            {
                Console.WriteLine("  " + (i + 1) + ". " + items[i]);
            }
            else
            {
                Console.WriteLine("  " + items[i]);
            }
        }
    }
    Console.WriteLine();
}

void DrawMenu2(string[] items, int[] items2, int row, int col, int index)
{
    Console.SetCursorPosition(col, row);
    for (int i = 0; i < items.Length; i++)
    {
        if (i == index)
        {
            Console.WriteLine("->" + (i + 1) + ". " + items[i] + " - " + items2[i]);
        }
        else
        {
            Console.WriteLine("  " + (i + 1) + ". " + items[i] + " - " + items2[i]);
        }
    }
    Console.WriteLine();
}