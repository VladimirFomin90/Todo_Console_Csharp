namespace C_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var todos = new List<string>();

            Console.WriteLine("Привет мой друг!");
            Console.WriteLine("Это программа позволяет создавать список задач");
            bool isExit = false;
            while (!isExit)
            {
                Console.WriteLine("Заглавная или строчная буква без разницы");
                Console.WriteLine();
                Console.WriteLine("[S] Посмотреть все задачи");
                Console.WriteLine("[A] Добавить задачу");
                Console.WriteLine("[R] Удалить задачу");
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

            void SeeAllTodos()
            {
                if (todos.Count == 0)
                {
                    Console.WriteLine("Список задач пуст!");
                    return;
                }
                for (int i = 0; i < todos.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {todos[i]}");
                }
                Console.WriteLine();
            }

            void AddTodo()
            {
                string description;
                do
                {
                    Console.WriteLine("Напиши название задачи");
                    description = Console.ReadLine();
                    Console.WriteLine();
                }
                while (!isDescriptionValid(description));

                todos.Add(description);
            }

            bool isDescriptionValid(string description)
            {
                if (description == "")
                {
                    Console.WriteLine("Пусто введите что-нибудь");
                    return false;
                }
                if (todos.Contains(description))
                {
                    Console.WriteLine("Введи не повторяющееся название задачи!");
                    return false;
                }
                return true;
            }

            void RemoveTodo()
            {
                if (todos.Count == 0)
                {
                    Console.WriteLine("Список задач пуст!");
                    return;
                }
                bool isIndexValid = false;
                while (!isIndexValid)
                {
                    Console.WriteLine("Выбери номер задачи чтобы удалить ее");
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
                        Console.WriteLine("Задача удалена под номером " + todoToBeRemoved);
                    }
                    else
                    {
                        Console.WriteLine("Нет такой задачи под этим номером! Выбери действительный номер!");
                    }






                }

            }

        }

    }
}
