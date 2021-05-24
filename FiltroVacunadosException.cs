using System;

public class FiltroVacunadosException : ApplicationException
{
    
    public FiltroVacunadosException()
    {
        //Bloquear al usuario si se detecta que ha utilizado el sistema más de 3 veces y genera una excepcion        
    }

    public FiltroVacunadosException(string message)
        : base(message)
    {        
        EscribirLogErrores(message);
        EnviarCorreoError(message);
        //Bloquear al usuario si se detecta que ha utilizado el sistema más de 3 veces y genera una excepcion
    }

    public FiltroVacunadosException(string message, Exception innerException)
        : base(message, innerException)
    {
        EscribirLogErrores(message);
        EnviarCorreoError(message);
        //Bloquear al usuario si se detecta que ha utilizado el sistema más de 3 veces y genera una excepcion
    }
    
    private bool EscribirLogErrores(string error){
        //Escribir aquí en base de datos o en archivo de logs de errores el error
        return true;
    }

    private bool EnviarCorreoError(string error){
        //Avisar del error al administrador o usuario implicado
        return true;
    }

}