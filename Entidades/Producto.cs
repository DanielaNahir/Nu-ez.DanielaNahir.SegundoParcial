using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    /// <summary>
    /// Clase que representa a un producto a la venta
    /// </summary>
    public class Producto
    {
        private string nombre;
        private float precio;

        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public Producto()
        {
            this.nombre = "";
            this.precio = 0;
        }
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="precio"></param>
        public Producto(string nombre, float precio)
        {
            this.precio = precio;
            this.nombre = nombre;
        }

        /// <summary>
        /// Propiedad de lectura y escritura del atributo nombre
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        /// <summary>
        /// Propiedad de lectura y escritura del atributo precio
        /// </summary>
        public float Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }

        /// <summary>
        /// Verifica si este Producto esta en la lista de productos recibida
        /// </summary>
        /// <param name="lista">Lista sobre la que se verificara si esta</param>
        /// <returns>Booleano que representa si esta en la lista (true) o no (false)</returns>

        public virtual bool VerificarIgualdad(List<Producto> lista)
        {
            return lista.Contains(this);
        }

        /// <summary>
        /// Muestra nombre y precio de Producto
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{this.nombre}: {this.precio}";
        }

        /// <summary>
        /// Compara dos Producto
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Booleano true son iguales o false si no lo son</returns>
        public override bool Equals(object? obj)
        {
            bool result = false;
            if (obj is Producto)
            {
                result = this == (Producto)obj;
            }
            return result;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Sobrecarga del operador == para comparar dos Producto
        /// </summary>
        /// <param name="m1">Producto</param>
        /// <param name="m2">Producto</param>
        /// <returns>Booleano true son iguales o false si no lo son</returns>
        public static bool operator ==(Producto p1, Producto p2)
        {
            return p1.nombre == p2.nombre && p1.precio == p2.precio;
        }
        /// <summary>
        /// Sobrecarga del operador != para comparar dos Producto
        /// </summary>
        /// <param name="m1">Producto</param>
        /// <param name="m2">Producto</param>
        /// <returns>Booleano false son iguales o true si no lo son</returns>
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
    }
}
