using consoleLybrary;
class Program
{
public static void Main()
{
//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

//CODIGO DEL HOSPITAL 
   Hospitales varela1 = new Hospitales("Hospital Varela", 30, 8, "mejor morir 321");//se intancia un hospital a cual se le dara Tiempos y ambulancias

    varela1.RegistrarTiempo(15.5);//
    varela1.RegistrarTiempo(22.0);//se agrega tiempo para el promedio
    varela1.RegistrarTiempo(11.3);//

    bool exito = varela1.DespacharAmbulancia(4);//se utilizan ambulancias 

    Console.WriteLine(varela1); //doy el informe (aca por que me gusta que el error se muestre despues del)

    if (exito == false)//condicion necesaria para ejecutar con normalidad
{
    Console.WriteLine("Error: No hay suficientes ambulancias.");//en caso de no cumplirla 
}
    Console.WriteLine(varela1.ModificarCantidadAmbulancias(-1));//se agregan o quitan ambulancias y se actualiza la infromacion 
//CODIGO DEL HOSPITAL */

//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

//CODIGO DE LAS UNIDADDES DE ATENCION PRIMARIA (UAP)
    UAP salitaQuilmes = new UAP("Salita Quilmes", 10,"calle falsa 123"); //creo la salita
    salitaQuilmes.RegistrarTiempo(15.5);//
    salitaQuilmes.RegistrarTiempo(22.0);//se agrega tiempo para el promedio
    salitaQuilmes.RegistrarTiempo(20.3);//
    Console.WriteLine(salitaQuilmes); //doy el informe de la salita
//CODIGO DE LAS UNIDADDES DE ATENCION PRIMARIA (UAP)*/

//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

//CODIGO PARA LA UNIDAD DE ADMINISTRACION (UA) 
    UnidadesAdministrativas zonaSur = new UnidadesAdministrativas("Zona Sanitaria Sur (Quilmes - Varela)", "El infierno");//creo la Unidad Administrativa 

    
    zonaSur.AgregarBase(varela1); //agrego las bases sanitarias que quiera (tienen que existir)
    zonaSur.AgregarBase(salitaQuilmes); //agrego las bases sanitarias que quiera (tienen que existir)

    Console.WriteLine("\n\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
    Console.WriteLine("  REPORTE FINAL DE LA UNIDAD ADMINISTRATIVA  ");                                       //este es un separador para que sea mas prolijo o llamativo 
    Console.WriteLine("\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\n");
    
    Console.WriteLine(zonaSur);

    Console.WriteLine("\n--- SIMULANDO REORGANIZACIÓN MUNICIPAL ---");
    Console.WriteLine(zonaSur.EliminarBase(salitaQuilmes));

    Console.WriteLine("\n\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
    Console.WriteLine("  NUEVO REPORTE ACTUALIZADO  ");
    Console.WriteLine("\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\n");
    
    Console.WriteLine(zonaSur);    
 //CODIGO PARA LA UNIDAD DE ADMINISTRACION (UA)*/

//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//



//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

/*PEDIR DIRECCION A QUIEN QUIERAS(HOSPITA, UA Y UAP)

    Console.WriteLine(varela1.PedirDireccion());
    Console.WriteLine(salitaQuilmes.PedirDireccion());
    Console.WriteLine(zonaSur.PedirDireccion()); 

PEDIR DIRECCION A QUIEN QUIERAS */

/*CANTIDAD DE AMBULANCIAS TOTALES DISPONIBLES DE LA (UA)
Console.WriteLine(zonaSur.ReporteBreveAmbulancias());
*/

/*CALCULA EL TIEMPO PROMEDIO DE UNA UA (TOMANDO A TODOS LOS HOSPITALES Y UAP)
Console.WriteLine(zonaSur.ReporteBreveTiempoMedio());
*/

//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//


}

}




