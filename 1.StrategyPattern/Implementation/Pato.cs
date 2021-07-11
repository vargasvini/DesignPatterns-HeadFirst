using Strategy.Interface;
using System;

namespace Strategy.Implementation
{
    public abstract class Pato
    {
        public void Nadar()
        {
            Console.WriteLine("Assim como todos os patos eu sei nadar!");
        }
    }

    public class PatoSelvagem : Pato
    {
        IVooComportamento vooComportamento;
        IGrasnarComportamento grasnarComportamento;

        public PatoSelvagem(IVooComportamento vooComportamento, IGrasnarComportamento grasnarComportamento)
        {
            this.vooComportamento = vooComportamento;
            this.grasnarComportamento = grasnarComportamento;
        }

        public void Voar()
        {
            vooComportamento.Voo();
        }

        public void Grasnar()
        {
            grasnarComportamento.Grasnar();
        }
    }

    public class PatoDaCidade : Pato
    {
        IVooComportamento vooComportamento;
        IGrasnarComportamento grasnarComportamento;

        public PatoDaCidade(IVooComportamento vooComportamento, IGrasnarComportamento grasnarComportamento)
        {
            this.vooComportamento = vooComportamento;
            this.grasnarComportamento = grasnarComportamento;
        }

        public void Voar()
        {
            vooComportamento.Voo();
        }

        public void Grasnar()
        {
            grasnarComportamento.Grasnar();
        }
    }

    public class PatoDeBorracha : Pato
    {
        IGrasnarComportamento grasnarComportamento;

        public PatoDeBorracha(IGrasnarComportamento grasnarComportamento)
        {
            this.grasnarComportamento = grasnarComportamento;
        }

        public void Grasnar()
        {
            grasnarComportamento.Grasnar();
        }
    }
}
