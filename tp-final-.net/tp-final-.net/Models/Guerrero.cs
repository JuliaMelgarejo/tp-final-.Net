namespace tp_final_.net.Models
{
    public class Guerrero: ISuperHeroe
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public int Fuerza { get; set; }
        public int Salud { get; set; }
        public string PoderEspecial { get; set; }

        public Guerrero(string nombre)
        {
            Nombre = nombre;
            Tipo = "Guerrero";
            Fuerza = 7;
            Salud = 5;
            PoderEspecial = "Manejar 2 espadas al mismo tiempo ";
        }

        public string Atacar() => "Golpea a su objetivo con el arma indicada";
        public string Defender() => "Se defiende esquivando ataques";

    }
}
