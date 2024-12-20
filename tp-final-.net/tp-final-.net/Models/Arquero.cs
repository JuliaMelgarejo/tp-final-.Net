namespace tp_final_.net.Models
{
    public class Arquero: ISuperHeroe
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public int Fuerza { get; set; }
        public int Salud { get; set; }
        public string PoderEspecial { get; set; }

        public Arquero(string nombre)
        {
            Nombre = nombre;
            Tipo = "Arquero";
            Fuerza = 5;
            Salud = 5;
            PoderEspecial = "Dispara flechas con fuego";
        }

        public string Atacar() => "Dispara una flecha al objetivo";
        public string Defender() => "Se defiende escondido";

    }
}
