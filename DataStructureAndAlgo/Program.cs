using System.Transactions;

public class Program
{

    class Info
    {
        private readonly int _id;
        private readonly string _password;


        public int Id { get; }
        public string password { get; }
        public string firstName { get; set; } = String.Empty;
        public string lastName { get; set; } = String.Empty;

        public Info(string password, int id)
        {
            _password = password;
            _id = id;
        }

        public void getInfo()
        {
            Console.WriteLine("Enter First Name: ");
            string fn = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter Last Name: ");
            string ln = Console.ReadLine();
            Console.Clear();

            
            Console.WriteLine($"Welcome {fn} {ln}! Hope you enjoy your stay.");
        }



        private static void Main(string[] args)
        {
            Info info = new("sdf", 123);
            info.getInfo();
        }
    }
}