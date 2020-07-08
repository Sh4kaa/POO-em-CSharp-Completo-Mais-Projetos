using System;
using System.Collections.Generic;


namespace restricoesGenerics.Services
{
    class CalculationService
    {
        public T Max<T>(List<T> list) where T : IComparable
        {
            if(list.Count == 0)
            {
                throw new ArgumentException("The list can not be empty");
            }
            
            T max = list[0];
            for(int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(max) > 0) // se oq estiver na lista[i] comparado com max[0] for maior que 0=(igualdade de objetos(maior que zero representa uma posição alfabetica maior) )
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
}
