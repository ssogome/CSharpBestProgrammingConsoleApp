using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBestProgrammingConsoleApp
{
    public interface IVegetable
    {
        void Clean(Vegetable vegi);
        void Serve(Vegetable vegi);
        void Steam(Vegetable vegi, int t);
        void Fry(Vegetable vegi, int t);
        void Bake(Vegetable vegi, int t);
    }
}
