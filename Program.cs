

class Program
{
    static void Main(string[] args)

     {
        Encapsulation.Gun gun = new Encapsulation.Gun(isLoaded: true);

        gun.Shoot();

        Encapsulation.Class1 class1 = new Encapsulation.Class1();

        class1.MaxSum();
        class1.MinSum();
        class1.Sort();

     }

}