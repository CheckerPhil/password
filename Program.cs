public class Program{
    public static void Main(){
        while(true){
            int passwordLenght;
            String password = "";
            Char[] chars = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&".ToCharArray();
            
            Console.WriteLine("Number of Chars:");
            String passwordLenghtString = Console.ReadLine();
            passwordLenght = Int32.Parse(passwordLenghtString);

            for(int i = 1; i <= passwordLenght; i ++){
                Random rnd = new Random();
                password = password + chars[rnd.Next(0,chars.Length)];
            }
            Console.WriteLine(password);

            Console.WriteLine("Do you want to generate another password? (y/n)");
            String line = Console.ReadLine();
            switch(line){
                case "Y":
                case "y":
                    break;
                case "N":
                case "n":
                Environment.Exit(0);
                break;
            }
        }
    }
}