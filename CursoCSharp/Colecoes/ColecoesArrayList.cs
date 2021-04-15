using System;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesArrayList
    {
        public static void Executar()
        {
            var arraylist = new ArrayList
            {
                "Palavra",
                3,
                true
            };
            arraylist.Add(3.14);    //adicionei um double;

            foreach (var item in arraylist)
            {
                Console.WriteLine("{0} => {1}", item, item.GetType()); //Vai mostrar no console que tipo de dado foi inserido no arraylist
            }
        }
    }
}
