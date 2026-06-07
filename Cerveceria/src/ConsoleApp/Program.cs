using System;


namespace ConsoleLibrary
{
Console.WriteLine("Hello, World!");
AfterOffice afterOffice = new AfterOffice();
Cerveza cerveza1 = new CervezaRubiaNacional();
Cerveza cerveza2 = new CervezaNegraNacional();
Cerveza cerveza3 = new CervezaRubiaImportada();

TipoVaso vaso1 = new Vaso();
TipoVaso vaso2 = new Chopp();  
TipoVaso vaso3 = new Jarra();


vaso1.Cerveza = cerveza1;
vaso2.Cerveza = cerveza2;
vaso3.Cerveza = cerveza3;


afterOffice.AgregarCervezasAlPedido(2, vaso1);

afterOffice.AgregarCervezasAlPedido(1, vaso2);

Console.WriteLine("La venta total del día es " + afterOffice.ObtenerVentasTotalesConMargen());
}