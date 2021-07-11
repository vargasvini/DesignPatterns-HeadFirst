using Strategy.Interface;
using System;

namespace Strategy.Implementation
{
    public class GrasnarBrinquedo : IGrasnarComportamento
    {
        public void Grasnar()
        {
            Console.WriteLine("Se me apertar eu meio que faço um barulho de apito!");
        }
    }

    public class GrasnarNormal : IGrasnarComportamento
    {
        public void Grasnar()
        {
            Console.WriteLine("Estou grasnando loucamente! Quack quack");
        }
    }
}
