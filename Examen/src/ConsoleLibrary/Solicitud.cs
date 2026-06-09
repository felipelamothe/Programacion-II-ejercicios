namespace ConsoleLibrary
{
    public class Solicitud
    {
        private string _categoria;
        private int _complejidad;

        public string Categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }

        public int Complejidad
        {
            get { return _complejidad; }
            set { _complejidad = value; }
        }

        public Solicitud(string categoria, int complejidad)
        {
            this.Categoria = categoria;
            this.Complejidad = complejidad;
        }
    }
}