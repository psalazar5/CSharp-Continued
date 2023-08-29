namespace Enumerations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Enums = special 'class' that contains a set of named integer constants. 
            //        Use enums when you have values that you know will not change. 
            //        To get the integer value from an item, you must explicitly convert

            //        name = integer

            Console.WriteLine(Planets.Pluto + " is a planet and it is # " + (int)Planets.Pluto);
            Console.WriteLine(Planets.Pluto + " is planet #" + (int)Planets.Pluto);

            string namePlanet_Earth = PlanetRadius.Earth.ToString();
            int radiusPlanet_Earth = (int)PlanetRadius.Earth;
            Console.WriteLine($"Planet: {namePlanet_Earth} Radius: {radiusPlanet_Earth}" + "km" );

            double volume = Volume(PlanetRadius.Earth);
            Console.WriteLine($"Planet: {Planets.Earth} Radius: {radiusPlanet_Earth}km Volume: {volume} + km^3");
            Console.ReadLine();
        }
        public static double Volume(PlanetRadius radius)
        {
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);
            return volume;
        }
    }

    enum Planets
    {
        Mercury = 1, 
        Venus = 2, 
        Earth = 3,
        Mars = 4, 
        Jupiter = 5, 
        Saturn = 6, 
        Uranus = 7, 
        Neptune = 8, 
        Pluto = 9
    }

    enum PlanetRadius
    {
        Mercury = 2439,
        Venus = 6051,
        Earth = 6371,
        Mars = 3389,
        Jupiter = 69911,
        Saturn = 58232,
        Uranus = 25362,
        Neptune = 24622,
        Pluto = 1188
    }

}