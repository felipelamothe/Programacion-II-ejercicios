namespace GimnasioAPP
{
    public class Actividad
    {
        private string nombre;
        private string descripcion;
        private decimal preciomensual;
        private string instructor;
        private string dias;
        private string horario;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }

        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public decimal PrecioMensual
        {
            get { return preciomensual; }
            set { preciomensual = value; }
        }
        public string Instructor
        {
            get { return instructor; }
            set { instructor = value; }
        }
        public string Dias
        {
            get { return dias; }
            set { dias = value; }
        }
        public string Horario
        {
            get { return horario; }
            set { horario = value; }
        }
        public Actividad(string nombre, decimal preciomensual)
        {
            Nombre = nombre;
            PrecioMensual = preciomensual;
        }
    }
}
