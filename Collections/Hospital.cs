using System;
using System.Collections.Generic;
using System.Linq;

class Hospital
{
    class Patient
    {
        public string Name { get; set; }
        public int Severity { get; set; }

        public Patient(string name, int severity)
        {
            Name = name;
            Severity = severity;
        }
    }

    static void Main()
    {
        List<Patient> patients = new List<Patient>
        {
            new Patient("rahul", 3),
            new Patient("gola", 5),
            new Patient("bottel", 2)
        };

        var sortedPatients = patients.OrderByDescending(p => p.Severity).ToList();

        foreach (var patient in sortedPatients)
        {
            Console.WriteLine(patient.Name +"Severity: "+patient.Severity);
        }

    }
}
