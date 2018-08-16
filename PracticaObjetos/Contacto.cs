﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrácticaObjetos
{
    class Contacto
    {
        public string Nombre { get; set; }
        public string TelefonoCasa { get; set; }
        public string TelefonoCelular { get; set; }
        public string Direccion { get; set; }
        public string CorreoElectronico { get; set; }
        public Contacto()
        {
            Nombre = "Nuevo contacto";
            TelefonoCasa = "(000) 000 - 0000";

        }
        public Contacto(string nombre)
        {
            Nombre = nombre;
        }
        public Contacto(string nombre, string telefonoCelular, string telefonoCasa, string direcion, string correoElectronico)
        {
            Nombre = nombre;
            TelefonoCasa = telefonoCasa;
            TelefonoCelular = telefonoCelular;
            Direccion = direcion;
            CorreoElectronico = correoElectronico;
        }
    }
}
