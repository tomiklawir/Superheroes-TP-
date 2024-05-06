const int INGRESAR_SUP1 = 1, INGRESAR_SUP2 = 2, PELEAR = 3, SALIR = 4;
string nombre, ciudad;
double peso, fuerza, velocidad, skill1, skill2;
int opcion;

do
{
    Console.WriteLine("Ingrese una opcion: INGRESAR SUPERHEROE 1 = 1, INGRESAR SUPERHEROE 2 = 2, PELEAR = 3, SALIR = 4;");
    opcion = int.Parse(Console.ReadLine());
}while(opcion < 1 && opcion > 4);

while(opcion != 4)
{
    switch(opcion){
        case 1: 
        nombre = IngresarString("Ingrese el nombre del superheroe");
        ciudad = IngresarString("Ingrese la ciudad del superheroe");
        peso = IngresarNumero("Ingrese el peso del superheroe");
        do{
        fuerza = IngresarNumero("Ingrese la fuerza del superheroe");
        }while(fuerza < 1 || fuerza > 100);
        do{
        velocidad = IngresarNumero("Ingrese la velocidad del superheroe");
        }while(fuerza < 1 || fuerza > 100);

        Superheroe s1 = new Superheroe(nombre, ciudad, peso, fuerza, velocidad);
        Console.WriteLine("Se ha creado el superheroe " + s1.Nombre);
        break;
        
        case 2:
        nombre = IngresarString("Ingrese el nombre del superheroe");
        ciudad = IngresarString("Ingrese la ciudad del superheroe");
        peso = IngresarNumero("Ingrese el peso del superheroe");
        do{
        fuerza = IngresarNumero("Ingrese la fuerza del superheroe");
        }while(fuerza < 1 || fuerza > 100);
        do{
        velocidad = IngresarNumero("Ingrese la velocidad del superheroe");
        }while(fuerza < 1 || fuerza > 100);

        Superheroe s2 = new Superheroe(nombre, ciudad, peso, fuerza, velocidad);
        Console.WriteLine("Se ha creado el superheroe " + s2.Nombre);
        break;
        case 3:
        break;
        
        do{
        Console.WriteLine("Ingrese una opcion: INGRESAR SUPERHEROE 1 = 1, INGRESAR SUPERHEROE 2 = 2, PELEAR = 3, SALIR = 4;");
        opcion = int.Parse(Console.ReadLine());
        }while(opcion < 1 && opcion > 4);
    }
}

static double IngresarNumero(string mensaje)
{
    double num;
    Console.WriteLine(mensaje);
    num = double.Parse(Console.ReadLine());
    return num;
}
static string IngresarString(string mensaje)
{
    string r;
    do{
        Console.WriteLine(mensaje);
        r = Console.ReadLine();
    }while(r == string.Empty);
    return r;
}