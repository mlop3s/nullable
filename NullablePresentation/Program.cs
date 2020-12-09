#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullablePresentation
{
    public sealed class Prescription
    {
        public long Id { get; }
        public string Posology { get; }
        public string Drug { get; }
        public string? Agent { get;  }

        public Prescription(long id, string posology, string drug, string? agent)
            => (Id, Posology, Drug, Agent) = (id, posology, drug, agent);
    }

    class Program
    {
        static void Main()
        {
            var aspirin = new Prescription(1, "1-0-1-0", "Aspirin", "Acetylsalicylsäure");
            var ibuprofen = new Prescription(1, "0-1-1-0", "Ibuprofen", null);

            PrintPrescription(aspirin);
            PrintPrescription(ibuprofen);
        }

        private static void PrintPrescription(Prescription prescription)
        {
            if (prescription.Agent is null)
            {
                Console.WriteLine(
                    $@"
Prescription Id: {prescription.Id} 
Posology:        {prescription.Posology} [{prescription.Posology.Length}]
Drug:            {prescription.Drug} [{prescription.Drug.Length}]
");
            }
            else
            {
                Console.WriteLine(
    $@"
Prescription Id: {prescription.Id} 
Posology:        {prescription.Posology} [{prescription.Posology.Length}]
Drug:            {prescription.Drug} [{prescription.Drug.Length}]
Agent:           {prescription.Agent} [{prescription.Agent?.Length}]
"
    );
            }
        }
    }
}
