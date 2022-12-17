namespace PropriedadesMetodos.Models
{
    public class LeituraArquivo
    {
        public (bool Sucesso, string[] Linhas ,int QuantidadedeLinhas) LerArquivo(string caminho)
        {    
            try
            {
             string[] linhas = File.ReadAllLines(caminho);
             return (true ,linhas , linhas.Count());
            }catch(Exception )
            {
             return(false ,new string[0] , 0);
            }

        }
        
    }
}