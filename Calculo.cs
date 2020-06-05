namespace aula11Polimorfismo
{
    public class Calculo
    {

        //Sobrecarregar é dar diferenter argumentos ao mesmo metodo e pode usar diferentes metodos (string, int, void, float etc)

        //Nenhum argumento
        public string Calcular(){
            return "A vida do player está completa";
        }
        
        //Com 1 argumento
        public string Calcular(int vida){
            return "A quantidade de vida atual do player é de"  + vida;
        }
        //Com 2 argumentos usando int
        public string Calcular(int vida, int defesa){
            return "A vida do player calculado com a defesa é de"  + (vida+defesa);
        }

            //Com 3 argumentos usando int
        public string Calcular(int vida, int defesa, int escudo){
            return "A vida do palyer calculado junto com a defesa e o escudo é de"  + (vida+defesa+escudo);
        }

        //Com 2 argumentos usando string
        public string Calcular(string nome, string sobrenome){
            return "O nome do personagem completo é"  + (nome+sobrenome);
        }
        
    }
}