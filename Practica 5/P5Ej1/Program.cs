using P5Ej1;

Cuenta c1 = new Cuenta();
Cuenta c2 = new Cuenta();
List<Cuenta> cuentas = Cuenta.Cuentas;
// se recuperó la lista de cuentas creadas
cuentas[0].Depositar(50);
// se depositó 50 en la primera cuenta de la lista devuelta
cuentas.RemoveAt(0);
Console.WriteLine(cuentas.Count);
// se borró un elemento de la lista devuelta
// pero la clase Cuenta sigue manteniendo todos
// los datos "La cuenta id: 1 tiene 50 de saldo"
cuentas = Cuenta.Cuentas;
// se recuperó nuevamente la lista de cuentas
Console.WriteLine(cuentas.Count);
cuentas[0].Extraer(30);
//se extrajo 30 de la cuenta id: 1 que tenía 50 de saldo