using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBestProgrammingConsoleApp
{
    public class ActOn: IVegetable
    {
        public void SteamCorn()
        {

            SteamVegetable(new Corn(), 15);

        }



        public void SteamSpinach()
        {

            SteamVegetable(new Spinach(), 8);

        }


        public void SteamVegetable(Vegetable vegetable, int timeInMinutes)
        {
            Clean(vegetable);
            Steam(vegetable, Minutes(timeInMinutes));
            Serve(vegetable);
        }

        public void FryVegetable(Vegetable vegetable, int timeInMinutes)
        {
            Clean(vegetable);
            Fry(vegetable, Minutes(timeInMinutes));
            Serve(vegetable);
        }

        public void BakeVegetable(Vegetable vegetable, int timeInMinutes)
        {
            Clean(vegetable);
            Bake(vegetable, Minutes(timeInMinutes));
            Serve(vegetable);
        }

        public void Clean(Vegetable vegi)
        {
            Console.WriteLine("Vegetable is cleaned!");
           // throw new NotImplementedException("Do something");
        }
        public void Serve(Vegetable vegi)
        {
            //throw new NotImplementedException("Do something");
            Console.WriteLine("Vegetable is served!");
        }
        public void Steam(Vegetable vegi, int t)
        {
            // throw new NotImplementedException("Do something");
            Console.WriteLine("Vegetable is steamed!");
        }
        public void Fry(Vegetable vegi, int t)
        {
            // throw new NotImplementedException("Do something");
            Console.WriteLine("Vegetable is fried!");
        }
        public void Bake(Vegetable vegi, int t)
        {
            //throw new NotImplementedException("Do something");
            Console.WriteLine("Vegetable is baked!");
        }

        public int Minutes(int amount)
        {
            return (amount/60);
        }

        public void SteamVegetableWithAction(Vegetable vegetable, int timeInMinutes)
        {
            CookVegetable(vegetable, Steam, timeInMinutes);
        }

        public void FryVegetableWithAction(Vegetable vegetable, int timeInMinutes)
        {
            CookVegetable(vegetable, Fry, timeInMinutes);
        }

        public void BakeVegetableWithAction(Vegetable vegetable, int timeInMinutes)
        {
            CookVegetable(vegetable, Bake, timeInMinutes);
        }



        public void CookVegetable(Vegetable vegetable, Action<Vegetable, int> cookingAction, int timeInMinutes)
        {

            Clean(vegetable);

            cookingAction(vegetable, Minutes(timeInMinutes));

            Serve(vegetable);

        }
    }
}
