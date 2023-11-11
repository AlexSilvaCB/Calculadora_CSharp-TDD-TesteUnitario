using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace new_talent
{
    public class Calculadora
    {
        private List<string> ListaHistorico;
        private DateTime date;

        public Calculadora()
        {
            ListaHistorico = new List<string>();
            date = DateTime.Now;
        }

         public int Soma(int val01, int val02)
        {
            int resultado = val01 + val02;
            ListaHistorico.Insert(0, $"{val01} + {val02} = {resultado} : {date}.");
            return resultado;
        }

         public int Subtracao(int val01, int val02)
        {
            int resultado = val01 - val02;
            ListaHistorico.Insert(0, $"{val01} - {val02} = {resultado} : {date}.");
            return resultado;
        }

         public int Multiplicacao(int val01, int val02)
        {
            int resultado = val01 * val02;
            ListaHistorico.Insert(0, $"{val01} * {val02} = {resultado} : {date}.");
            return resultado;
        }

         public int Divisao(int val01, int val02)
        {
            int resultado = val01 / val02;
            ListaHistorico.Insert(0, $"{val01} / {val02} = {resultado} : {date}.");
            return resultado;
        }

        public List<string> Historico()
        {
            ListaHistorico.RemoveRange(3, ListaHistorico.Count - 3);
            return ListaHistorico;
        }
    }
}