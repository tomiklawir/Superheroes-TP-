const int INGRESAR_SUP1 = 1, INGRESAR_SUP2 = 2, PELEAR = 3, SALIR = 4;
string nombre, ciudad, ganador;
double peso, fuerza, velocidad, skill1, skill2, diferencia;
int opcion;
Superheroe s1 = new Superheroe ("", "", 0, 0, 0);
Superheroe s2 = new Superheroe ("", "", 0, 0, 0);

do
{
    Console.WriteLine("Ingrese una opcion: INGRESAR SUPERHEROE 1 = 1, INGRESAR SUPERHEROE 2 = 2, PELEAR = 3, SALIR = 4;");
    opcion = int.Parse(Console.ReadLine());
}while(opcion < INGRESAR_SUP1 && opcion > SALIR);

while(opcion != SALIR)
{
    switch(opcion){
        case INGRESAR_SUP1: 
        nombre = IngresarString("Ingrese el nombre del superheroe");
        ciudad = IngresarString("Ingrese la ciudad del superheroe");
        peso = IngresarNumero("Ingrese el peso del superheroe");
        do{
        fuerza = IngresarNumero("Ingrese la fuerza del superheroe");
        }while(fuerza < 1 || fuerza > 100);
        do{
        velocidad = IngresarNumero("Ingrese la velocidad del superheroe");
        }while(fuerza < 1 || fuerza > 100);

        s1 = new Superheroe(nombre, ciudad, peso, fuerza, velocidad);
        Console.WriteLine("Se ha creado el superheroe " + s1.Nombre);
        break;
        
        case INGRESAR_SUP2:
        nombre = IngresarString("Ingrese el nombre del superheroe");
        ciudad = IngresarString("Ingrese la ciudad del superheroe");
        peso = IngresarNumero("Ingrese el peso del superheroe");
        do{
        fuerza = IngresarNumero("Ingrese la fuerza del superheroe");
        }while(fuerza < 1 || fuerza > 100);
        do{
        velocidad = IngresarNumero("Ingrese la velocidad del superheroe");
        }while(fuerza < 1 || fuerza > 100);

        s2 = new Superheroe(nombre, ciudad, peso, fuerza, velocidad);
        Console.WriteLine("Se ha creado el superheroe " + s2.Nombre);
        break;

        case PELEAR:
        skill1 = s1.ObtenerSkill();
        skill2 = s2.ObtenerSkill();

        if(skill1 > skill2){
            ganador = s1.Nombre;
            diferencia = skill1 - skill2;
        }
        else{
            ganador = s2.Nombre;
            diferencia = skill2 - skill1;
        }
        if(diferencia > 30){
            Console.WriteLine($"Ganó {ganador} por amplia diferencia");
        }
        else if(diferencia >= 10 && diferencia < 30){
            Console.WriteLine($"Ganó {ganador}. ¡Fue muy parejo!");
        }
        else if(diferencia < 10){
            Console.WriteLine($"Ganó {ganador}. ¡No le sobró nada!");
        }
        break;
        
        
    }
    do{
        Console.WriteLine("Ingrese una opcion: INGRESAR SUPERHEROE 1 = 1, INGRESAR SUPERHEROE 2 = 2, PELEAR = 3, SALIR = 4;");
        opcion = int.Parse(Console.ReadLine());
    }while(opcion < 1 && opcion > 4);
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