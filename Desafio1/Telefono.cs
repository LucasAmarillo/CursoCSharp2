using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    class Telefono
    {
        public Telefono(string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
        }
        private string modelo;
        private string marca;
        private int codigoOperador; // 1, 2 o 3

        public string Modelo
        {
            get { return modelo; }
        }
        public string Marca
        {
            get { return marca; }
        }
        public string NumeroTelefonico { get; set; }
        public int CodigoOperador
        {
            get { return codigoOperador; }
            set
            {
                if (value > 1 && value < 4)
                {
                    codigoOperador = value;
                }
                else
                {
                    codigoOperador = 0;
                }
            }
        }
        public string llamar()
        {
            return "Realizando la llamada...";
        }
        public string llamar(string contacto)
        {
            return "Llamando a " + contacto;
        }
    }
}
