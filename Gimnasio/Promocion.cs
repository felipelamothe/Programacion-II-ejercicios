using System.Collections.Generic;

namespace GimnasioAPP
{

    public class Promocion
    {
        // Atributos privados
        private string _nombre;
        private List<Actividad> _actividadesIncluidas;
        private decimal _porcentajeDescuento;

        // Propiedades públicas (Getters y Setters extensos)
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public List<Actividad> ActividadesIncluidas
        {
            get { return _actividadesIncluidas; }
            set { _actividadesIncluidas = value; }
        }

        public decimal PorcentajeDescuento
        {
            get { return _porcentajeDescuento; }
            set { _porcentajeDescuento = value; }
        }

        // Constructor
        public Promocion(string nombre, decimal descuento)
        {
            _nombre = nombre;
            _porcentajeDescuento = descuento;
            _actividadesIncluidas = new List<Actividad>(); // Inicializamos la lista aquí
        }
    }
}