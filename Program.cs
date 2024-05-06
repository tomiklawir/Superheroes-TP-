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
        Superheroe superheroe1 = ObtenerSuperheroe();
        Console.WriteLine("Se ha creado el superheroe " + superheroe1.Nombre);
        break;
        
        case 2:
        Superheroe superheroe2 = ObtenerSuperheroe();
        Console.WriteLine("Se ha creado el superheroe " + superheroe2.Nombre);
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
    Console.WriteLine(mensaje);
    r = Console.ReadLine();
    return r;
}   
Superheroe ObtenerSuperheroe()
{
    Superheroe superheroe = new Superheroe();
do{
superheroe.Nombre= IngresarString("ingrese el nombre");
}while(superheroe.Nombre == string.Empty);

do{
superheroe.Ciudad= IngresarString("ingrese la ciudad");
}while(superheroe.Ciudad == string.Empty);

do{
superheroe.Peso= IngresarNumero("ingrese el peso");
}while(superheroe.Peso < 0);

do{
superheroe.Velocidad = IngresarNumero("ingrese un valor para la velocidad");
}while(superheroe.Velocidad < 1 && superheroe.Velocidad > 100);

do{
superheroe.Fuerza = IngresarNumero("ingrese un valor para la fuerza");
}while(superheroe.Fuerza < 1 && superheroe.Fuerza > 100);

return superheroe;
}
