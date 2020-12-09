#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullablePresentation
{
    public class Prescription
    {
        public long Id { get; set; }
        public string Posology { get; set; }
        public string Drug { get; set; }
        public string Agent { get; set; } 
    }

    class Program
    {
        static void Main(string[] args)
        {
            var prescription = new Prescription();
            Console.WriteLine(
$@"
Prescription Id: {prescription.Id}
Posology:        {prescription.Posology}
Drug:            {prescription.Drug}
Agent:           {prescription.Agent}
"
);
        }
    }
}
