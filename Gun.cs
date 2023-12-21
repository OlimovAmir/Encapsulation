using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Gun
    {
        private bool isLoaded;

        private void Reload()
        {
            Console.WriteLine("Заражаю...");
            isLoaded = true;

            Console.WriteLine("Заражено");

        }

        private void Shoot() 
        {
            if (!isLoaded)
            {
                Console.WriteLine("Орудие не заряжено!");
                Reload();
            }
            Console.WriteLine("Пыщ - Пыщь\n");
            isLoaded= false;
        }
    }
}
