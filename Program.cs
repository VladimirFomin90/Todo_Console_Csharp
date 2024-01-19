namespace C_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var todos = new List<string>();

            Console.WriteLine("Привет мой друг!");
            Console.WriteLine("Это программа позволяет создавать список заданий");
            bool isExit = false;
            while (!isExit)
            {
                Console.WriteLine("Заглавная или строчная буква без разницы");
                Console.WriteLine();
                Console.WriteLine("[S] Посмотреть все задания");
                Console.WriteLine("[A] Добавить задание");
                Console.WriteLine("[R] Удалить задание");
                Console.WriteLine("[E] Выход");
                Console.WriteLine();

                string userClick = Console.ReadLine();

                switch (userClick)
                {
                    case "S":
                    case "s":
                        SeeAllTodos();
                        break;
                    case "A":
                    case "a":
                        AddTodo();
                        break;
                    case "R":
                    case "r":
                        RemoveTodo();
                        break;
                    case "E":
                    case "e":
                        Console.WriteLine("Exit");
                        isExit = true;
                        break;
                    default:
                        Console.WriteLine("Выбери вариант из вышеперечисленных!");
                        break;
                }
            }


            Console.ReadKey();

            void AddTodo()
            {
                bool isTodosFill = false;
                while (!isTodosFill)
                {
                    Console.WriteLine("Напиши название задания");
                    var description = Console.ReadLine();
                    Console.WriteLine();

                    if (description == "")
                    {
                        Console.WriteLine("Пусто введите что-нибудь");
                    }
                    else if (todos.Contains(description))
                    {
                        Console.WriteLine("Введите уникальное todo!!!");
                    }
                    else
                    {
                        isTodosFill = true;
                        todos.Add(description);
                    }
                }
            }

            void SeeAllTodos()
            {
                if (todos.Count == 0)
                {
                    Console.WriteLine("Список заданий пуст!");
                }
                else
                {
                    for (int i = 1; i < todos.Count; i++)
                    {
                        Console.WriteLine($"{i}. {todos[i]}");
                    }
                    Console.WriteLine();
                }
            }

            void RemoveTodo()
            {
                if (todos.Count == 0)
                {
                    Console.WriteLine("Список дел пуст!");
                    return;
                }
                bool isIndexValid = false;
                while (!isIndexValid)
                {
                    Console.WriteLine("Выбери номер задания чтобы удалить его");
                    SeeAllTodos();
                    var userInput = Console.ReadLine();

                    if (userInput == "")
                    {
                        Console.WriteLine("Ничего не выбрано!");
                        continue;
                    }
                    if (int.TryParse(userInput, out int index) && index >= 1 && index <= todos.Count)
                    {
                        var todoToBeRemoved = todos[index - 1];
                        todos.RemoveAt(index - 1);
                        isIndexValid = true;
                        Console.WriteLine("Задание удалено за номером " + );
                    }
                    else
                    {
                        Console.WriteLine("Нет такого задания под этим номером! Выбери действительный номер!");
                    }






                }

            }

        }

    }
}
