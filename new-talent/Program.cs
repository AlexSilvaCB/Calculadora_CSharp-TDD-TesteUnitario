using System;

namespace new_talent
{
    class Program
    {
        static void Main(string[] args)
        {

            var Calc = new Calculadora();

            var resultCalc = 0;
            
            resultCalc = Calc.Soma(10, 5);
            Console.WriteLine(resultCalc);

            resultCalc = Calc.Subtracao(10, 5);
            Console.WriteLine(resultCalc);

            resultCalc = Calc.Multiplicacao(10, 5);
            Console.WriteLine(resultCalc);

            resultCalc = Calc.Divisao(10, 5);
            Console.WriteLine(resultCalc);

            Calc.Historico().ForEach(delegate(string str){
                Console.WriteLine(str);
             });
        }
    }
}
