/* Getters e setters padrão */

/*
    class Person
    {
        string Name { get; set; }
    }
*/

// A sintaxe demonstrada acima tem o mesmo comportamento da sintaxe abaixo:
/*
    class Person
    {
        string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
*/

/* Usando métodos para instanciar classes */

/*
    class Bakery
    {
        public Bread fabricateBread(int weight)
        {
            return new Bread
            {
                Weight = weight,
                Type = "White"
            };
        }

        public Cake fabricateChocolateCake(string size)
        {
            return new Cake
            {
                Size = size,
                Flavour = "Chocolate"
            };
        }
    }
*/

/*
    class Bread
    {
        string _type = "";

        public int Weight { get; set; }
        public string Type
        {
            get { return _type; }
            set
            {
                if (value != "White" && value != "Wheat")
                    throw new ArgumentException("Invalid bread type");

                _type = value;
            }
        }
    }
*/

/*
    class Cake
    {
        public string Size { get; set; }
        public string Flavour { get; set; }
    }
*/

/* Utilizando o modificador static */

// As classes estáticas não são instanciáveis, ou seja, não é possível usar a chave new ou a sintaxe de
// inicialização de objetos para criar uma variável do tipo da classe. Para acessar os seus membros, devemos utilizar a própria classe!

/*
    public static class Trybe
    {
        public static string[] students = { "Luiza", "Bruno", "Patrícia", "Tiago" };

        public static string[] Students
        {
            get { return students; }
            set { students = value; }
        }

        public static int NumberOfStudents
        {
            get { return students.Length; }
        }

        public static bool IsStudent(string name)
        {
            return Array.Exists(students, s => s == name);
        }

        public static void PrintStudents()
        {
            Console.WriteLine(string.Join(", ", students));
        }
    }
*/
