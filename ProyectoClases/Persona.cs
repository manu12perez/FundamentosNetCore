using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public enum TipoGenero { Masculino, Femenino }
    public enum Paises { España, Francia, Alemania, Andorra, Tabarnia }

    public class Persona
    {
        public Persona()
        {
            Debug.WriteLine("Constructor PERSONA vacío");
            this.Domicilio = new Direccion(); //o se instancia en la clase o en en el form
        }

        public Persona(string nombre, string apellidos)
        {
            Debug.WriteLine("Constructor PERSONA 2 parámetros");
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }

        #region PROPIEDADES

        private string _DescripcionThis;
        public string this[int indice]
        {
            get { return this._DescripcionThis; }
            set {
                Random random = new Random();
                int aleat = random.Next(1, 20);
                this._DescripcionThis = "Descripción " + aleat;
            }
        }

        public Direccion Domicilio { set; get; }
        public Direccion DomicilioVacaciones { get; set; }

        private TipoGenero _Genero;
        public TipoGenero Genero
        {
            get { return this._Genero; }
            set
            {
                if (value != TipoGenero.Masculino &&
                    value != TipoGenero.Femenino)
                {
                    throw new Exception("Valor de género incorrecto");
                }
                else
                {
                    this._Genero = value;
                }
            }
        }
        public Paises Nacionalidad { get; set; }

        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        //CAMPO PRIVADO PARA LA EDAD
        private int _Edad;
        public int Edad
        {
            get { return this._Edad; }
            set
            {
                //DEBEMOS COMPROBAR EL VALOR DE LA EDAD QUE VIENE EN value
                if (value < 0)
                {
                    //SI NOS DAN UN VALOR INCORRECTO
                    //ERROR SILENCIOSO
                    //this._Edad = 0;
                    //LANZAMOS UNA EXCEPCION
                    throw new Exception("La edad no puede ser negativa");
                }
                else
                {
                    //TODO CORRECTO
                    this._Edad = value;
                }
            }
        }

        #endregion

        #region METODOS

        //METODO PARA DEVOLVER UN NOMBRE COMPLETO
        public string GetNombreCompleto()
        {
            return this.Nombre + " " + this.Apellidos;
        }

        //METODO PARA DEVOLVER LOS APELLIDOS Y EL NOMBRE
        public string GetNombreCompletoDelReves()
        {
            return this.Apellidos + " " + this.Nombre;
        }

        //METODO PARA NOMBRE Y APELLIDOS EN MAYUSCULA
        public string GetNombreCompletoMayuscula()
        {
            return (this.Nombre + " " + this.Apellidos).ToUpper();
        }

        //METODO PARA NOMBRE Y APELLIDOS EN MINUSCULA
        public string GetNombreCompletoMinuscula()
        {
            return (this.Nombre + " " + this.Apellidos).ToLower();
        }
        #endregion


    }
}
