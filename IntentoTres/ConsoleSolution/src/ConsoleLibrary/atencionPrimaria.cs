namespace consoleLybrary;
public class UAP : BaseSanitaria //CREO LA CLASE UAP Y HEREDO DE BASES SANITARIAS
{
public UAP(string _nombreBase, int _personal, string _direccion) //CONSTRUCTOR CON LA INFORMACION NECESARIA DE LAS UAP
    {
        this._nombreBase = _nombreBase;
        this._personal = _personal;
        this._direccion = _direccion;

    }
public override string ToString() //GENERO EL RETUR TEXTO PARA SER EJECUTADO EN EL MAIN
    {
        double promedio = CalcularPromedioTiempo(); // Lo hereda gratis de la base
        
        string texto = $"--- REPORTE DE LA UAP ---\n" +
                       $"Nombre: {_nombreBase}\n" +
                       $"Personal médico en salita: {_personal}\n" +
                       $"Tiempo medio de asistencia: {Math.Round(promedio, 2)} min.\n" +
                       $"* Las UAP no cuentan con flota de ambulancias *";

        return texto;
    }
}