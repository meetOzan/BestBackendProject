namespace BestBackendProject
{
    class klass
    {
        private int Veri { get; set; }
        private int _veri { get; set; } = 0;


        public klass(int Veri)
        {
            this.Veri = Veri;
        }
    }

    class Main
    {
        public static void main()
        {
            var nesne = new klass(5);

            Console.WriteLine("Neymiş Mesele \n");
            Console.WriteLine("Neymiş Dayı \n");
            Console.WriteLine(
                "Mesele en mutlu olduğun, o gün en güzel hayaller kurduğun o gün ölmekmiş ME-SE-LE ;) \n");
            Console.WriteLine(
                "Bir ihtimal daha var\nO da ölmek mi dersin?\nSöyle canım ne dersin?\nBir ihtimal daha var\nO da ölmek mi dersin?\nSöyle canım ne dersin?\nVuslatın başka âlem\nSen bir ömre bedelsin\nSen bir ömre bedelsin\nVuslatın başka âlem\nSen bir ömre bedelsin\nSen bir ömre bedelsin\nSükût etme nazlı yâr\nBeni mecnun edersin\nBeni mecnun edersin\nSükût etme nazlı yâr\nBeni mecnun edersin\nBeni mecnun edersin\nVuslatın başka âlem\nSen bir ömre bedelsin\nAh, sen bir ömre bedelsin\nVuslatın başka âlem\nSen bir ömre bedelsin\nSen bir ömre bedelsin \n");
        }


        public static void structA()
        {
            var personIso = new Person{name = "Ishak", age = 31};

            var personMustafa = new PersonConst("Mustaf",31);
        }

        public static void klasss()
        {
            var people = new People("1241298", "Dayı", true);
        }

        public static void program(string[] args)
        {
        }

    }
}