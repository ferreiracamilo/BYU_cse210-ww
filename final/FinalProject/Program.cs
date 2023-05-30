using System;

class Program{

    

    static void Main(string[] args)
    {
        List<Pet> _pets = new List<Pet>();
        List<Owner> _owners = new List<Owner>();
        List<Vet> _vets = new List<Vet>();
        List<Diagnostic> _diagnostics = new List<Diagnostic>();
        List<Treatment> _treatments = new List<Treatment>();
        List<Drug> _drugs = new List<Drug>();
        List<Visit> _vistis = new List<Visit>();

        int _option = 0;
        string fileName;

        do{
            _option = PrintMainMenu();
            if(_option != 13){
                switch(_option){
                    case 1:
                        Pet pet1 = RegisterNewPet();
                        _pets.Add(pet1);
                        break;
                }
            }
        }while(_option != 13);


    }

    private static int PrintMainMenu(){
        int option;
        Console.WriteLine("\nMenu Options:");
        Console.WriteLine("    1. Register new pet");
        Console.WriteLine("    2. Register new owner");
        Console.WriteLine("    3. Register new vet");
        Console.WriteLine("    4. Register new surgery");
        Console.WriteLine("    5. Register new cronic treatment");
        Console.WriteLine("    7. Register new simple treatment");
        Console.WriteLine("    8. Register new drug");
        Console.WriteLine("    9. Register new diagnostic");
        Console.WriteLine("    10. Register new visit due to discomfort");
        Console.WriteLine("    11. Register new visit due to control");
        Console.WriteLine("    12. Save current information");
        Console.WriteLine("    13. Quit");
        Console.Write("Select a choice from the menu: ");
        option = int.Parse(Console.ReadLine());
        return option;
    }

    private Pet PickPet(List<Pet> pets){
        for(int i=0; i < pets.Count(); i++){
            Pet pet = pets[i];
            Console.WriteLine($"{i+1}. {pet.GetName()} - {pet.GetAnimalType()} - {pet.GetBirthDate()}");
        }

        Console.Write("\nPick the pet based on the previous list: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        return pets[index];
    }

    private Vet PickVet(List<Vet> vets){
        for(int i=0; i < vets.Count(); i++){
            Vet vet = vets[i];
            Console.WriteLine($"{i+1}. {vet.GetDocid()} - {vet.GetEmail()}");
        }

        Console.Write("\nPick the vet based on the previous list: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        return vets[index];
    }

    private Drug PickDrug(List<Drug> drugs){
        for(int i=0; i < drugs.Count(); i++){
            Drug drug = drugs[i];
            Console.WriteLine($"{i+1}. {drug.GetName()} - {drug.GetPresentation()}");
        }

        Console.Write("\nPick the drug based on the previous list: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        return drugs[index];
    }

    private static Pet RegisterNewPet(){
        Console.WriteLine("\n**** PET REGISTRATION ****");

        Console.Write("\nProvide your pet's name: ");
        string name = Console.ReadLine();
        
        Console.Write("Provide your pet's birthdate (MM/DD/YYYY): ");
        DateOnly birthDate = Utils.StringToDate(Console.ReadLine());

        Console.Write("Provide your pet's animal type (dog, mouth, cat, etc): ");
        string animalType = Console.ReadLine();

        Console.Write("Provide your pet's animal breed (sharpei, rotweiller, etc): ");
        string breed = Console.ReadLine();

        int id = Utils.CreateUniqueId();

        Pet newPet = new Pet(name, birthDate, animalType, breed, id);
        return newPet;
    }

    private static Owner RegisterNewOwner(){
        Console.WriteLine("\n**** OWNER REGISTRATION ****");
        
        Console.Write("\nProvide your document id: ");
        int docId = int.Parse(Console.ReadLine());

        Console.Write("Provide your phone number: ");
        string phoneNumber = Console.ReadLine();

        Console.Write("Provide your address: ");
        string address = Console.ReadLine();

        Console.Write("Provide your address: ");
        string email = Console.ReadLine();
        
        Console.Write("Provide your payment method (cash, debit, card, check): ");
        string monthlyFeePaymentMethod = Console.ReadLine();

        Owner owner1 = new Owner(docId, phoneNumber, address, email, monthlyFeePaymentMethod);
        return owner1;
    }

    private static Vet RegisterNewVet(){
        Console.WriteLine("\n**** OWNER REGISTRATION ****");
        
        Console.Write("\nProvide your document id: ");
        int docId = int.Parse(Console.ReadLine());

        Console.Write("Provide your phone number: ");
        string phoneNumber = Console.ReadLine();

        Console.Write("Provide your address: ");
        string address = Console.ReadLine();

        Console.Write("Provide your address: ");
        string email = Console.ReadLine();
        
        Vet vet1 = new Vet(docId, phoneNumber, address, email);
        return vet1;
    }

    private static Diagnostic RegisterNewDiagnostic(Pet pet, Vet vet){
        Console.WriteLine("\n**** DIAGNOSTIC REGISTRATION ****");

        Console.Write("\nProvide severity of diagnostic (from 1 to 10): ");
        int severity = int.Parse(Console.ReadLine());

        Diagnostic diagnostic = new Diagnostic(pet, severity, vet, Utils.CreateUniqueId());

        return diagnostic;
    }

    private static Surgery RegisterNewSurgery(Pet pet, Vet vet){
        Console.WriteLine("\n**** SURGERY REGISTRATION ****");

        Console.Write("\nProvide anestesia for the surgery: ");
        string anestesia = Console.ReadLine();

        Surgery surgery = new Surgery(pet, Utils.CreateUniqueId(), anestesia, vet);

        Console.Write("\nAdd procedure: ");
        string procedure1 = Console.ReadLine();
        surgery.AddProcedure(procedure1);

        return surgery;
    }

    private static SimpleTreatment RegisterSimpleTreatment(Pet pet, Vet vet, List<Drug> drugs){
        Console.WriteLine("\n**** SIMPLE TREATMENT REGISTRATION ****");

        SimpleTreatment simpleTreatment = new SimpleTreatment(pet, Utils.CreateUniqueId(), vet);

        int randomIndex = new Random().Next(0, drugs.Count);
        simpleTreatment.AddDrug(drugs[randomIndex]);

        return simpleTreatment;
    }

    private static CronicTreatment RegisterCronicTreatment(Pet pet, Vet vet, List<Drug> drugs){
        Console.WriteLine("\n**** CRONIC TREATMENT REGISTRATION ****");

        Console.Write("\nProvide weeks of prescription for treatment: ");
        int durationWeeks = int.Parse(Console.ReadLine());

        CronicTreatment cronicTreatment = new CronicTreatment(pet, Utils.CreateUniqueId(), durationWeeks, vet);

        int randomIndex = new Random().Next(0, drugs.Count);
        cronicTreatment.AddDrug(drugs[randomIndex]);

        return cronicTreatment;
    }






}