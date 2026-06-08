using System.Collections.Generic;
namespace GimnasioAPP
{
public class Socio
    {
        private string _nombre;
        private string _apellido;
        private string _dni;
        private List<Actividad> _actividades;
        private IEstrategiaCuota _estrategiaDeCobro;
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public string Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }

        public List<Actividad> Actividades
        {
            get { return _actividades; }
            set { _actividades = value; }
        }

        public IEstrategiaCuota EstrategiaDeCobro
        {
            get { return _estrategiaDeCobro; }
            set { _estrategiaDeCobro = value; }
        }

        // Constructor
        public Socio()
        {
            _actividades = new List<Actividad>(); // Inicializamos la lista
        }

        // Métodos de negocio
        public void AgregarActividad(Actividad actividad)
        {
            _actividades.Add(actividad);
        }

        public decimal CalcularCuotaMensual()
        {
            if (_estrategiaDeCobro == null) return 0;
            return _estrategiaDeCobro.CalcularCuota(this);
        }
    }
}