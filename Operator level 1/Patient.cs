using System;

class Patient
{
    public static string HospitalName = "Medhanta";
    private static int totalPatients = 0;
    public readonly int PatientID;
    public string Name;
    public int Age;
    public string Ailment;

   public Patient(string name, int age, string ailment)
    {
        this.Name = name;
        this.Age = age;
        this.Ailment = ailment;
        this.PatientID = ++totalPatients; 
    }
    public static int GetTotalPatients()
    {
        return totalPatients;
    }
    
    public void DisplayDetails()
    {
        if (this is Patient) 
        {
            Console.WriteLine($"Patient ID: {PatientID}\nName: {Name}\nAge: {Age}\nAilment: {Ailment}\nHospital: {HospitalName}\n");
        }
    }


    static void Main()
    {
        Patient p1 = new Patient("Shivansh", 30, "Fever");
        Patient p2 = new Patient("Udit", 25, "Head-Ache");
        p1.DisplayDetails();
        p2.DisplayDetails();
        Console.WriteLine("Total Patients Admitted: " + Patient.GetTotalPatients());
    }
}
