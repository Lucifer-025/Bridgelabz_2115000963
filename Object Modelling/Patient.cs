using System;
using System.Collections.Generic;

class Patient
{
    public string Name;
    public Patient(string name)
    {
        Name = name;
    }
}

class Doctor
{
    public string Name;
    public Doctor(string name)
    {
        Name = name;
    }

    public void Consult(Patient patient)
    {
        Console.WriteLine("Doctor " + Name + " is consulting " + patient.Name);
    }
}

class Hospital
{
    public string Name;
    public List<Doctor> doctors = new List<Doctor>();

    public Hospital(string name)
    {
        Name = name;
    }

    public void AddDoctor(Doctor doctor)
    {
        doctors.Add(doctor);
    }
}

class Program
{
    static void Main()
    {
        Hospital hospital = new Hospital("Lucknow Hospital");
        Doctor doctor = new Doctor("Dr. Bisen");
        Patient patient = new Patient("Rahul");

        hospital.AddDoctor(doctor);
        doctor.Consult(patient);
    }
}
