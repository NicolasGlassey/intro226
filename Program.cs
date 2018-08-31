using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    class Program
    {
        #region private attributes
        private static char operateur = '+';
        private static int operande1 = 4;
        private static int operande2 = 2;
        private static int resultat = 0;
        #endregion private attributes

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            Console.Write("Saisissez la première opérance :\n");
            operande1 = int.Parse(Console.ReadLine());
            Console.Write("Saisissez l'operateur :\n");
            operateur = (char)Console.Read();
            Console.Write("Saisissez la première opérance :\n");
            operande1 = int.Parse(Console.ReadLine());
            Console.Write("Le résultat du calcul " + operande1 + operateur + operande2 + " \n");
            resultat = additionner(operande1, operande2);
            Console.Write(resultat);
            Console.ReadLine();
        }

        private static int additionner (int op1)
        {
            return op1 + op2;
        }
    }
}
