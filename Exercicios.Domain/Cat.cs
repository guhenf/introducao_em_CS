using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Domain
{
    public class Cat : IPet
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string Photo { get; set; }
        public Owner Owner { get; set; }

        public string HowMuchHowMuchShouldDogEat(int weight)
        {
            throw new NotImplementedException();
        }

        public void ValidateInfosTryCatch()
        {
            throw new NotImplementedException();
        }
    }
}
