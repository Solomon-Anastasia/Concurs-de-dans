using System;

namespace Concurs_de_dans
{
    class Dancer
    {
        public string CodDansator { get; }
        public string Nume { get; }
        public string Prenume { get; }
        public string Sex { get; }
        public DateTime DataNasterii { get; }
        public int Experienta { get; }
        public string DenumireTipDans { get; }
        public string Email { get; }
        public string Telefon { get; }
        public string Adresa { get; }
        public string NumeInstitutie { get; }
        public string Locul { get; }

        // Variabila ce returneaza varsta in ani
        public string Varsta 
        { 
            get {
                var today = DateTime.Today;
                var age = today.Year - DataNasterii.Year;
                if (DataNasterii.Date > today.AddYears(-age))
                    age--;

                return $"{age}";
            }
        }

        // Variabila ce returneaza genul de tipul "Femenin"/"Masculin"
        public string GetGen
        {
            get {
                if (Sex.Equals("F"))
                    return "Femenin";
                else return "Masculin";
            }
        }


        // Variabila ce retureaza numele si prenumele dansatorului
        public string GetNameSurname
        {
            get {
                return $"{Nume} {Prenume}";
            }
        }

        // Variabila ce retureaza numele, prenumele si varsta dansatorului
        public string GetNameSurnameAndAge
        {
            get {
                return $"{Nume} {Prenume} {Varsta} ani";
            }
        }


        // Variabila ce returneaza codul, numele, prenumele, locul dansatorului
        public string GetCodeNameSurnameAndPlace
        {
            get {
                return $"{Locul}: {CodDansator} {Nume} {Prenume}";
            }
        }
    }
}
