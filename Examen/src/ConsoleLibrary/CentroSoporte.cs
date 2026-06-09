namespace ConsoleLibrary
{
   public class CentroSoporte
    {
        private List<IEstrategiaSoporte> _estrategias;

        public CentroSoporte()
        {
            // Instanciamos la lista en el constructor
            this._estrategias = new List<IEstrategiaSoporte>();
        }

        public void AgregarEstrategia(IEstrategiaSoporte estrategia)
        {
            this._estrategias.Add(estrategia);
        }

        // Método principal donde se evalúa el ciclo
        public void AtenderSolicitud(Solicitud solicitud)
        {
            bool resuelta = false;

            foreach (IEstrategiaSoporte estrategia in this._estrategias)
            {
                if (estrategia.PuedeResolver(solicitud))
                {
                    estrategia.Resolver(solicitud);
                    resuelta = true;
                    break; // Frena el ciclo porque ya se resolvió
                }
                else
                {
                    Console.WriteLine("Evaluando La estrategia actual no puede resolver la solicitud");
                }
            }

            // Opcional: Validación extra por si la lista estuviera vacía o mal configurada
            if (!resuelta)
            {
                Console.WriteLine("Error critico: Ningun nivel pudo atender la solicitud (Falta proveedor externo en la configuracion)");
            }
        }
    }
}