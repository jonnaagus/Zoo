namespace Zoo
{
    // Elev: Jonna Gustafsson
    // Klass: .NET23
    class Program
    {
        static void Main()
        {
            // Create different kind of animals
            Animal shark = new Animal("Alf", 32, "Havet", 0, false);
            Lion lion = new Lion("Mufasa", 10, "Savannen", 4, true, "kött");
            Lioness lioness = new Lioness("Sarabi", 9, "savannen", 4, true, true);
            LionCub lioncub = new LionCub("Simba", 1, "savannen", 4, true, true);
            Animal giraffe = new Animal("Kurt", 40, "Savannen", 4, true);
            Tiger siberiantiger = new Tiger("Randi", 15, "savannen", 4, true, "Sibirisk tiger");
            Monkey chimpanzee = new Monkey("Kajsa", 4, "regnskogen", 2, true, true);
            Gorilla gorilla = new Gorilla("Hugo", 17, "regnskogen", 2, true, true);
            Orangutang orangutan = new Orangutang("Arnold", 20, "regnskogen", 2, true, true);
            Animal elephant = new Animal("Ella", 55, "Savannen", 4, true);



            // Call the MakeSound method for each animal
            shark.MakeSound();
            lion.MakeSound();
            lioness.MakeSound();
            lioncub.MakeSound();
            giraffe.MakeSound();
            siberiantiger.MakeSound();
            chimpanzee.MakeSound();
            gorilla.MakeSound();
            orangutan.MakeSound();
            elephant.MakeSound();
        }
    }
}