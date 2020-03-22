using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            B.Add(3);
            B.Add(4);
            B.Add(5);

            /*A.ExceptWith(B);  ver diferença entre conjunto A e B, removendo do conjunto A o que pertence ao B*/

            /*B.Remove(4);*/ //remover

            /*A.UnionWith(B); vai uni conjunto A com B, tirando os repetidos*/

            /*A.IntersectWith(B); intersecção: vai mostrar em evidencia oq os conjuntos tem em comum,
             * porque ambos se repetem nos conjuntos A e B*/

            foreach(int x in A)
            {
                Console.WriteLine(x);
            }

            /*Console.Write("Digite um numero inteiro: ");
            int N = int.Parse(Console.ReadLine());

            if (B.Contains(N))
            {
                Console.WriteLine(N + " pertence ao conjunto B");
            }
            else
            {
                Console.WriteLine(N+ " não pertence ao conjunto B");
            }*/

        }
    }
}
