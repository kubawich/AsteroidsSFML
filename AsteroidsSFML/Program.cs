using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace AsteroidsSFML
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Setup game = new Setup(1000, 600, "Test");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
