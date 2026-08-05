//using Encapsulation;
//using System.Runtime.Intrinsics.X86;

//7.Hospital Patient Management
//Description: Design a system to manage patients in a hospital.
//Abstract Class:
//Create an abstract class Patient with fields: patientId, name, and age.
//Add an abstract method CalculateBill().
//Implement a concrete method GetPatientDetails().
//Subclasses:
//Extend Patient into InPatient and OutPatient.
//Implement CalculateBill() differently for each subclass.
//Interface:
//Implement an interface IMedicalRecord.
//Define methods AddRecord() and ViewRecords().
//Encapsulation:
//Protect sensitive patient data like diagnosis and medical history.
//Polymorphism:
//Use a Patient reference to handle different patient types dynamically.
//Display billing details based on polymorphic behavior.


using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
   abstract internal class Patient
    {
        int patientId;
        private string diagnosis { get; set; } = string.Empty;
        private string medicalHistory { get; set; } = string.Empty;
        string name;
        int age;
        public Patient(int patientId, string name, int age)
        {
            this.patientId = patientId;
            this.name = name;
            this.age = age;
        }
        protected void setDiagnoseAndMedicalRecord(string diagnosis , string medicalHistory)
        {
            this.diagnosis = diagnosis;
            this.medicalHistory = medicalHistory;
        }
        protected void showDiagnoseAndMedicalRecord()
        {
            Console.WriteLine("Diagnosis: " + diagnosis);
            Console.WriteLine("Medical History: " + medicalHistory);
        }
        public abstract int calculateBill();
        public void getPateientsDetails()
        {
            Console.WriteLine("Patient ID: " + patientId);
            Console.WriteLine("Patient Name: " + name);
            Console.WriteLine("Patient Age: " + age);
        }
    }
    internal class InPatient: Patient , IMedicalRecord
    {
        public InPatient(int patientId, string name, int age) : base(patientId, name, age)
        {
        }
        public override int calculateBill()
        {
            return 1000;
        }
        public void AddRecord(string diagnosis, string medicalHistory)
        {
            setDiagnoseAndMedicalRecord(diagnosis, medicalHistory);
            Console.WriteLine("Added successfully medical record for InPatient");
        }
        public void ViewRecords()
        {
            Console.WriteLine("Viewing medical records for InPatient");
            showDiagnoseAndMedicalRecord();
        }

    }
    internal class OutPatient : Patient , IMedicalRecord
    {
        public OutPatient(int patientId , string name , int age): base(patientId, name, age)
        {

        }
        public void AddRecord(string diagnosis, string medicalHistory)
        {
            setDiagnoseAndMedicalRecord(diagnosis, medicalHistory   );
            Console.WriteLine("Added successfully medical record for OutPatient");
        }
        public void ViewRecords()
        {
            Console.WriteLine("Viewing medical records for OutPatient");
            showDiagnoseAndMedicalRecord();
        }
        public override int calculateBill()
        {
            return 1;
        }
    }
    interface IMedicalRecord
    {
        void AddRecord(string diagnosis, string medicalHistory);
        void ViewRecords();
    }
}
