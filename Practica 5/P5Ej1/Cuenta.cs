using System.Collections.Concurrent;
using System.Reflection.Metadata.Ecma335;

namespace P5Ej1;

public class Cuenta
{
    private static int s_numCuenta = 0;
    private static int s_numDep = 0;
    private static int s_numExt = 0;
    private static int s_numExtFallidas = 0;
    private static int s_totDep = 0;
    private static int s_totExt = 0;
    private static int s_totSal = 0;
    private static List<Cuenta> s_cuentas = new List<Cuenta>();
    private int _monto = 0;
    
    public Cuenta(){
        s_numCuenta++;
        Console.WriteLine($"Se creo la cuenta id={s_numCuenta}");
        s_cuentas.Add(this);
    }

    public Cuenta Depositar(int monto){
        _monto = _monto + monto;
        s_totSal = s_totSal + monto;
        s_totDep = s_totDep + monto;
        s_numDep++;
        Console.WriteLine($"se deposito {monto} de la cuenta {s_numCuenta} (Saldo={_monto})");
        return this;
    }

    public Cuenta Extraer(int monto){
        if(_monto - monto >= 0){
            _monto = _monto - monto;
            s_numExt++;
            s_totExt = s_totExt + monto;
            s_totSal = s_totSal - monto;
            Console.WriteLine($"se extrajo {monto} de la cuenta {s_numCuenta} (Saldo={_monto})");
        }
        else{
            Console.WriteLine("Operacion denegada - Saldo Insuficiente");
            s_numExtFallidas++;
        }
        return this;
    }

    public static void ImprimirDetalle(){
        Console.WriteLine($"CUENTAS CREADAS: {s_numCuenta}\nDEPOSITOS: {s_numDep} - Total depositado: {s_totDep}\nEXTRACCIONES: {s_numExt} - Total extraido: {s_totExt}\nSaldo: {s_totSal}\n* Se denegaron {s_numExtFallidas} extracciones por falta de fondos");
    }

    public static List<Cuenta> Cuentas{
        get => new List<Cuenta>(s_cuentas);
    }
}
