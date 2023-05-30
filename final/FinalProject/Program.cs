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
        List<Visit> _visits = new List<Visit>();

        int _option = 0;

        do{
            _option = PrintMainMenu();
            if(_option != 12){
                switch(_option){
                    case 1:
                        //New Pet
                        Pet pet1 = RegisterNewPet();
                        _pets.Add(pet1);
                        break;
                    case 2:
                        //New Owner
                        if(_pets.Count() == 0){
                            Console.WriteLine("Load pets before performing this operation");
                            Thread.Sleep(1000);
                            break;
                        }else{
                            Owner owner1 = RegisterNewOwner();
                            Pet owner1_pet = PickPet(_pets);
                            owner1.AddPet(owner1_pet);
                            _owners.Add(owner1);
                            break;
                        }
                    case 3:
                        //New Vet
                        Vet vet1 = RegisterNewVet();
                        break;
                    case 4:
                        //New Surgery
                        if(_pets.Count() == 0 || _vets.Count() == 0){
                            Console.WriteLine("Load pets and vets before performing this operation");
                            Thread.Sleep(1000);
                            break;
                        }else{
                            Pet surgeryPet = PickPet(_pets);
                            Vet surgeryVet = PickVet(_vets);
                            Surgery surgery1 = RegisterNewSurgery(surgeryPet, surgeryVet);
                            _treatments.Add(surgery1);
                            break;
                        }
                    case 5:
                        //new cronic treatment
                        if(_pets.Count() == 0 || _vets.Count() == 0 || _drugs.Count() == 0){
                            Console.WriteLine("Load pets, vets and drugs before performing this operation");
                            Thread.Sleep(1000);
                            break;
                        }else{
                            Pet cronicTreatmentPet = PickPet(_pets);
                            Vet cronicTreatmentVet = PickVet(_vets);
                            CronicTreatment surgery1 = RegisterNewCronicTreatment(cronicTreatmentPet, cronicTreatmentVet, _drugs);
                            _treatments.Add(surgery1);
                            break;
                        }
                    case 6:
                        //new simple treatment
                        if(_pets.Count() == 0 || _vets.Count() == 0 || _drugs.Count() == 0){
                            Console.WriteLine("Load pets, vets and drugs before performing this operation");
                            Thread.Sleep(1000);
                            break;
                        }else{
                            Pet simpleTreatmentPet = PickPet(_pets);
                            Vet simpleTreatmentVet = PickVet(_vets);
                            SimpleTreatment simpleTreatment1 = RegisterNewSimpleTreatment(simpleTreatmentPet, simpleTreatmentVet, _drugs);
                            _treatments.Add(simpleTreatment1);
                            break;
                        }
                    case 7:
                        //new drug
                        Drug drug1 = RegisterNewDrug();
                        _drugs.Add(drug1);
                        break;
                    case 8:
                        //new diagnostic
                        if(_pets.Count() == 0 || _vets.Count() == 0){
                            Console.WriteLine("Load pets and vets before performing this operation");
                            Thread.Sleep(1000);
                            break;
                        }else{
                            Pet diagnostic1Pet = PickPet(_pets);
                            Vet diagnostic1Vet = PickVet(_vets);
                            Diagnostic diagnostic1 = RegisterNewDiagnostic(diagnostic1Pet,diagnostic1Vet);
                            _diagnostics.Add(diagnostic1);
                            break;
                        }
                    case 9:
                        //new visit discomfort
                        if(_pets.Count() == 0){
                            Console.WriteLine("Load pets before performing this operation");
                            Thread.Sleep(1000);
                            break;
                        }else{
                            Pet visitDiscomfort1Pet = PickPet(_pets);
                            VisitDiscomfort visitDiscomfor1 = RegisterNewVisitDiscomfort(visitDiscomfort1Pet);
                            _visits.Add(visitDiscomfor1);
                            break;
                        }
                    case 10:
                        //new visit control
                        if(_pets.Count() == 0){
                            Console.WriteLine("Load pets before performing this operation");
                            Thread.Sleep(1000);
                            break;
                        }else{
                            Pet visitControl1Pet = PickPet(_pets);
                            VisitControl visitControl1 = RegisterNewVisitControl(visitControl1Pet);
                            _visits.Add(visitControl1);
                            break;
                        }
                    case 11:
                        //list all information
                        int overallLength = _pets.Count() + _owners.Count() + _vets.Count() + _diagnostics.Count() + _treatments.Count() + _drugs.Count() + _visits.Count();
                        if(overallLength <= 0){
                            Console.WriteLine("There's no record to list/display");
                            Thread.Sleep(1000);
                            break;
                        }
                        
                        if(_pets.Count() > 0){
                            Console.WriteLine("\n*** PETS LOGGED ***");
                            foreach(Pet pet in _pets){
                                Console.WriteLine(pet);
                            }
                            Thread.Sleep(5000);
                        }

                        if(_owners.Count() > 0){
                            Console.WriteLine("\n*** OWNERS LOGGED ***");
                            foreach(Owner owner in _owners){
                                Console.WriteLine(owner);
                            }
                            Thread.Sleep(5000);
                        }

                        if(_vets.Count() > 0){
                            Console.WriteLine("\n*** VETS LOGGED ***");
                            foreach(Vet vet in _vets){
                                Console.WriteLine(vet);
                            }
                            Thread.Sleep(5000);
                        }

                        if(_diagnostics.Count() > 0){
                            Console.WriteLine("\n*** DIAGNOSTICS LOGGED ***");
                            foreach(Diagnostic diagnostic in _diagnostics){
                                Console.WriteLine(diagnostic);
                            }
                            Thread.Sleep(5000);
                        }

                        if(_treatments.Count() > 0){
                            Console.WriteLine("\n*** TREATMENTS LOGGED ***");
                            foreach(Treatment treatment in _treatments){
                                Console.WriteLine(treatment);
                            }
                            Thread.Sleep(5000);
                        }

                        if(_drugs.Count() > 0){
                            Console.WriteLine("\n*** DRUGS LOGGED ***");
                            foreach(Drug drug in _drugs){
                                Console.WriteLine(drug);
                            }
                            Thread.Sleep(5000);
                        }

                        if(_visits.Count() > 0){
                            Console.WriteLine("\n*** VISITS LOGGED ***");
                            foreach(Visit visit in _visits){
                                Console.WriteLine(visit);
                            }
                            Thread.Sleep(5000);
                        }
                        break;
                }
            }
            // Console.Clear();
        }while(_option != 12);


    }

    private static int PrintMainMenu(){
        int option;
        Console.WriteLine("\nMenu Options:");
        Console.WriteLine("    1. Register new pet");
        Console.WriteLine("    2. Register new owner");
        Console.WriteLine("    3. Register new vet");
        Console.WriteLine("    4. Register new surgery");
        Console.WriteLine("    5. Register new cronic treatment");
        Console.WriteLine("    6. Register new simple treatment");
        Console.WriteLine("    7. Register new drug");
        Console.WriteLine("    8. Register new diagnostic");
        Console.WriteLine("    9. Register new visit due to discomfort");
        Console.WriteLine("    10. Register new visit due to control");
        Console.WriteLine("    11. List all information");
        Console.WriteLine("    12. Quit");
        Console.Write("Select a choice from the menu: ");
        option = int.Parse(Console.ReadLine());
        return option;
    }

    private static Pet PickPet(List<Pet> pets){
        for(int i=0; i < pets.Count(); i++){
            Pet pet = pets[i];
            Console.WriteLine($"{i+1}. {pet.GetName()} - {pet.GetAnimalType()} - {pet.GetBirthDate()}");
        }

        Console.Write("\nPick the pet based on the previous list: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        return pets[index];
    }

    private static Vet PickVet(List<Vet> vets){
        for(int i=0; i < vets.Count(); i++){
            Vet vet = vets[i];
            Console.WriteLine($"{i+1}. {vet.GetDocid()} - {vet.GetEmail()}");
        }

        Console.Write("\nPick the vet based on the previous list: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        return vets[index];
    }

    private static Drug PickDrug(List<Drug> drugs){
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
        Console.WriteLine("\n**** VET REGISTRATION ****");
        
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

    private static SimpleTreatment RegisterNewSimpleTreatment(Pet pet, Vet vet, List<Drug> drugs){
        Console.WriteLine("\n**** SIMPLE TREATMENT REGISTRATION ****");

        SimpleTreatment simpleTreatment = new SimpleTreatment(pet, Utils.CreateUniqueId(), vet);

        int randomIndex = new Random().Next(0, drugs.Count);
        simpleTreatment.AddDrug(drugs[randomIndex]);

        return simpleTreatment;
    }

    private static CronicTreatment RegisterNewCronicTreatment(Pet pet, Vet vet, List<Drug> drugs){
        Console.WriteLine("\n**** CRONIC TREATMENT REGISTRATION ****");

        Console.Write("\nProvide weeks of prescription for treatment: ");
        int durationWeeks = int.Parse(Console.ReadLine());

        CronicTreatment cronicTreatment = new CronicTreatment(pet, Utils.CreateUniqueId(), durationWeeks, vet);

        int randomIndex = new Random().Next(0, drugs.Count);
        cronicTreatment.AddDrug(drugs[randomIndex]);

        return cronicTreatment;
    }

    private static VisitDiscomfort RegisterNewVisitDiscomfort(Pet pet){
        Console.WriteLine("\n**** VISIT DISCOMFORT REGISTRATION ****");

        Console.Write("\nProvide a synthom related to the visit: ");
        string synthom = Console.ReadLine();

        VisitDiscomfort visitDiscomfort = new VisitDiscomfort(pet, Utils.CreateUniqueId());

        visitDiscomfort.AddSynthom(synthom);

        return visitDiscomfort;
    }

    private static VisitControl RegisterNewVisitControl(Pet pet){
        Console.WriteLine("\n**** VISIT CONTROL REGISTRATION ****");

        Console.Write("\nProvide a valuation related to the visit: ");
        string valuation = Console.ReadLine();

        VisitControl visitControl = new VisitControl(pet, Utils.CreateUniqueId());

        visitControl.AddValuation(valuation);

        return visitControl;
    }

    private static Drug RegisterNewDrug(){
        Console.WriteLine("\n**** DRUG REGISTRATION ****");

        Console.Write("\nProvide drug's name: ");
        string name = Console.ReadLine();

        Console.Write("\nProvide drug's type: ");
        string type = Console.ReadLine();

        Console.Write("\nProvide drug's presentation: ");
        string presentation = Console.ReadLine();

        Drug drug = new Drug(name, type, presentation, Utils.CreateUniqueId());

        return drug;
    }

}