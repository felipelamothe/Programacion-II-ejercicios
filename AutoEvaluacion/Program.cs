using ConsoleLibrary;


Documento objDocumento = new Documento();


objDocumento.Nombre = "miparcial.txt";
objDocumento.Texto = "Esto es el texto del documento";

ManejadorDocumentoStrategy objCompresion = new StrategyCompresion();

Empresa objEmpresa = new Empresa(objCompresion);

objEmpresa.Estrategia().ProcesarDocumento(objDocumento);


objEmpresa.CambiarEstrategia(new StrategyEncriptacion());   
objEmpresa.Estrategia().ProcesarDocumento(objDocumento);

