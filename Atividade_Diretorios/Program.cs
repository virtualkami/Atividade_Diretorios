namespace Atividade_Diretorios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // bloco try
            try
            {
                // var direcionada a um endereço
                var arquivos = from arquivo in Directory.EnumerateFiles(@"C:\Temp\servidorArquivos", "*.txt")
                               // procura da string "brasil"
                               where arquivo.ToLower().Contains("brasil")
                               // coleta arquivo com a condição encontrada
                               select arquivo;
                // mostra os arquivos que achou
                foreach (var item in arquivos) { Console.WriteLine(item); }
                // conta quantos arquivos foram encontrados
                Console.WriteLine(arquivos.Count<string>().ToString()+" Arquivos encontrados.");
            }
            // emitirá mensagem em caso de erro
            catch (Exception e) { Console.WriteLine(e.Message) ; }
        }
    }
}