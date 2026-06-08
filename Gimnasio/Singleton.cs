namespace GimnasioAPP
{
    public class GestorDePromociones
    {
        // Atributo estático privado que guarda la única instancia
        private static GestorDePromociones _instance;

        // La promoción activa actualmente
        private Promocion _promocionVigente;

        // Constructor privado para evitar que se instancie con 'new' desde afuera
        private GestorDePromociones() { }

        // Método de acceso global
        public static GestorDePromociones Instance()
        {
            if (_instance == null)
            {
                _instance = new GestorDePromociones();
            }
            return _instance;
        }

        public Promocion ObtenerPromocionVigente()
        {
            return _promocionVigente;
        }

        // Punto 3 del ejercicio: Métodos para que el gerente agregue o elimine promociones
        public void EstablecerPromocion(Promocion nuevaPromo)
        {
            _promocionVigente = nuevaPromo;
        }

        public void EliminarPromocion()
        {
            _promocionVigente = null;
        }
    }

}