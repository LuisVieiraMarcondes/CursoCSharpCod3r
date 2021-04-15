using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class Moto
    {
        //Atributos
        private string Marca;               //por padrão se não colocar o private ele automaticamente seria de condiçao privada também,
        private string Modelo;
        private uint Cilindrada;

        //Métodos

        public Moto(string marca, string modelo, uint cilindrada) //será o método construtor
        {
            SetMarca(marca);
            SetModelo(modelo);
            SetCilindrada(cilindrada);

        }
        public Moto() //segundo método construtor Padrão
        {

        }
        public string GetMarca() //método get recebe GetMarca em PascalCase, e tem a mesma variavel de retorno que é o mesmo tipo de retorno
        {                       //se ele não recebe nenhum parametro, então terei um return;
            return Marca;
        }
        public void SetMarca(string marca) //o método Set não retorna nada, vou receber o parametro da nova marca que eu vou "settar"
        {
            Marca = marca; //marca que é o parametro da função vai "settar" o valor do atributo da classe

        }
        public string GetModelo() {
            return Modelo;
        }
        public void SetModelo(string modelo)
        {
            Modelo = modelo;
        }
        public uint GetCilindrada()
        {
            return Cilindrada;
        }
        public void SetCilindrada(uint cilindrada)
        {   //1a opção
            //if(cilindrada > 0){
            //Cilindrada = cilindrada;
            //}
            //2a opção
            //Cilindrada = Math.Abs(cilindrada); // vai transformar todos valos em absolutos, então se o numero for negativo vai pra positivo e se positivo continua positivo
            //3a opção
            Cilindrada = cilindrada;
        }

    }


    class GetSet
    {
        public static void Executar()
        {
            var moto1 = new Moto("Kawasaki", "Ninja ZX-6R", 636); //aqui "settamos" direto no construtor

            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());

            var moto2 = new Moto();
            moto2.SetMarca("Honda");
            moto2.SetModelo("CG Titan");
            moto2.SetCilindrada(150);
            Console.WriteLine(moto2.GetMarca() + " " + moto2.GetModelo() + " " + moto2.GetCilindrada());

        }
    }
}
