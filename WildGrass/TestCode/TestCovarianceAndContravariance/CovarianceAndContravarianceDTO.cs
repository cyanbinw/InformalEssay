using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode.TestCovarianceAndContravariance
{
    public class DogDTO : ICovarianceAndContravariance
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Size { get; set; }
        public string Sleep { get; set; }

        public DogDTO()
        {
            Name = "Tom";
            Description = "";
            Size = 10;
        }

        public void Action()
        {
            
        }
    }

    public class CatDTO : ICovarianceAndContravariance
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Size { get; set; }
        public int Work { get; set; }

        public CatDTO()
        {
            Name = "Lily";
            Description = "";
            Size = 10;
        }

        public void Action()
        {

        }
    }
}
