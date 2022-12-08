namespace Conexão_Educacional.Crosscutting
{
    public class Extensions
    {
        public static void Type()
        {
            Console.Write("Digite: ");
        }
        public static void Holder(int level = 1300)
        {
            Thread.Sleep(level);
        }
        public static void PressAnyKey()
        {
            Console.WriteLine("Pressione ENTER para voltar");
            Console.ReadKey();
        }
    }
}
