using Strategy.Implementation;
using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            PatoDeBorracha patoDeBorracha = new PatoDeBorracha(new GrasnarBrinquedo());
            patoDeBorracha.Nadar();
            patoDeBorracha.Grasnar();

            Console.WriteLine("\n");
            PatoSelvagem patoSelvagem = new PatoSelvagem(new VooBatendoAsas(), new GrasnarNormal());
            patoSelvagem.Nadar();
            patoSelvagem.Grasnar();
            patoSelvagem.Voar();

            Console.WriteLine("\n");
            PatoDaCidade patoDaCidade = new PatoDaCidade(new VooPlanando(), new GrasnarNormal());
            patoDaCidade.Nadar();
            patoDaCidade.Grasnar();
            patoDaCidade.Voar();

        }
    }
}
