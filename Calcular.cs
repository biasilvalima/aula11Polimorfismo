namespace aula11Polimorfismo
{
    public class Calcular
    {
        public string Calcular(){
            return "A vida do player está completa";
        }

        public string Calcular(int vida){
            return "A quantidade de vida atual do player é de"  + vida;
        }

        public string Calcular(int vida, int defesa){
            return "A vida do player calculado com a defesa é de"  + (vida+defesa);
        }
        public string Calcular(int vida, int defesa, int escudo){
            return "A vida do palyer calculado junto com a defesa e o escudo é de"  + (vida+defesa+escudo);
        }

        public string Calcular(string nome, string sobrenome);
    }
}