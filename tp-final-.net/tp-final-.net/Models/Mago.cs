namespace tp_final_.net.Models
{
    public class Mago: ISuperHeroe
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public int Fuerza { get; set; }
        public int Salud { get; set; }
        public string PoderEspecial { get; set; }
        public Mago(string nombre)
        {
            Nombre = nombre;
            Tipo = "Mago";
            Fuerza = 10;
            Salud = 5;
            PoderEspecial = "Resta salud a su enemigo quedandosela el";
        }

        public string Atacar() => "Lanza algun hechizo";
        public string Defender() => "Se protege con un escudo semiesferico a prueba de los demas golpes";
    }
}
