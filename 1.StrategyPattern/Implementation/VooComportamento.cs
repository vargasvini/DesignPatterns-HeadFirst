using Strategy.Interface;
using System;

namespace Strategy.Implementation
{
    public class VooBatendoAsas : IVooComportamento
    {
        public void Voo()
        {
            Console.WriteLine("Estou batendo as asas!");
        }
    }

    public class VooPlanando : IVooComportamento
    {
        public void Voo()
        {
            Console.WriteLine("Estou planando!");
        }
    }
}
