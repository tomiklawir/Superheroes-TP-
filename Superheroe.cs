class Superheroe{

    public string Nombre { get; set; }
    public string Ciudad { get; set; }
    public double Peso { get; set; }
    public double Fuerza { get; set; }
    public double Velocidad { get; set; }

    public Superheroe(string nombre, string ciudad, double peso, double fuerza, double velocidad)
    {
        Nombre = nombre;
        Ciudad = ciudad;
        Peso = peso;
        Fuerza = fuerza;
        Velocidad = velocidad;
    }

    public double ObtenerSkill(){
        double velTot, fuerzaTot, numRand, skill;
        Random random = new Random();
        numRand = random.NextDouble();
        velTot = Velocidad * 0.6;
        fuerzaTot = Fuerza * 0.8;
        skill = velTot + fuerzaTot + numRand;
        return skill;
    }
}