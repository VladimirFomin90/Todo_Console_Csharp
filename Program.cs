namespace C_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var todos = new List<string>();

            Console.WriteLine("Привет мой друг!");
            bool isExit = false;
            while (!isExit)
            {
                Console.WriteLine("[S]ee all Todos");
                Console.WriteLine("[A]dd a Todo");
                Console.WriteLine("[R]emove a Todo");
                Console.WriteLine("[E]xit");

                string userClick = Console.ReadLine();

                switch (userClick)
                {
                    case "S":
                    case "s":
                        SeeAllTodos();
                        break;
                    case "A":
                    case "a":
                        //Console.WriteLine("Add a Todo");
                        AddTodo();
                        break;
                    case "R":
                    case "r":
                        Console.WriteLine("Remove a Todo");
                        break;
                    case "E":
                    case "e":
                        Console.WriteLine("Exit");
                        isExit = true;
                        break;
                    default:
                        Console.WriteLine("Choise right variant");
                        break;
                }
            }


            Console.ReadKey();

            void AddTodo()
            {
                bool isTodosFill = false;
                while (!isTodosFill)
                {
                    Console.WriteLine("Enter your a todo");
                    var description = Console.ReadLine();

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
                    Console.WriteLine("Список todo пуст!");
                }
            }

        }

    }
}
