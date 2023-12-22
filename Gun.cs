using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Gun
    {
        public Gun(bool isLoaded)
        {
            _isLoaded = isLoaded;
        }
        private bool _isLoaded;

        private void Reload()
        {
            Console.WriteLine("Заражаю...");
            _isLoaded = true;

            Console.WriteLine("Заражено");

        }

        public void Shoot() 
        {
            if (!_isLoaded)
            {
                Console.WriteLine("Орудие не заряжено!");
                Reload();
            }
            Console.WriteLine("Пыщ - Пыщь\n");
            _isLoaded= false;
        }
    }
}
