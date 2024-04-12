namespace P5Ej7;

public class Persona
{
    private String _nombre;
    private char _sexo;
    private int _dni;
    private DateTime _fechaDeNacimiento;


    public string Nombre{
        get => this._nombre;
        set => this._nombre = value;
    }
    public char Sexo{
        get => this._sexo;
        set => this._sexo = value;
    }
    public int Dni{
        get => this._dni;
        set => this._dni = value;
    }
    public DateTime FechaDeNacimiento{
        get => this._fechaDeNacimiento;
        set => this._fechaDeNacimiento = value;
    }
    public int Edad{
        get{
            int edad = DateTime.Today.Year - this._fechaDeNacimiento.Year;
            if(this._fechaDeNacimiento > DateTime.Today.AddYears(-edad)){ //pone ambas fechas en el mismo año y luego compara si la fecha del cumpleaños es posterior o inferior a la actual
                edad= edad -1; //resta un año si el cumpleaños de la persona paso este año o no
            }
            return edad;
        } 
    }

    public object this[int i]{
        get{
            switch (i)
            {
                case 0: return this._nombre;
                case 1: return this._sexo;
                case 2: return this._dni;
                case 3: return this._fechaDeNacimiento;
                case 4: return this.Edad;
                default: Console.WriteLine("numero invalido");
                    return null;
            }
        }
        set{
            switch (i)
            {
                case 0: this._nombre = (string)value;
                    break;
                case 1: this._sexo = (char)value;
                    break;
                case 2: this._dni = (int)value;
                    break;
                case 3: this._fechaDeNacimiento = (DateTime)value;
                    break;
                case 4: Console.WriteLine($"descartando edad: {value}");
                    break;
                default: Console.WriteLine("numero invalido");
                    break;
            }
        }
    }
}
