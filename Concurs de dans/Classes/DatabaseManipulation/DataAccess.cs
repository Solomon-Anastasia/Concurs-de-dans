using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Concurs_de_dans
{
    class DataAccess
    {
        // Metoda ce preia denumirile concursurilor
        public static List<string> GetCompetitionName()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ConcursDeDansDB")))
            {
                List<string> output = connection.Query<string>("dbo.selectCompetition").ToList();
                return output;
            }
        }

        // Metoda ce preia datele dansatorilor
        public static List<Dancer> GetDancers()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ConcursDeDansDB")))
            {
                List<Dancer> dancers = connection.Query<Dancer>("dbo.selectDancers").ToList();
                return dancers;
            }
        }

        // Metoda ce preia denumirea categoriilor de dans
        public static List<string> GetCategoryName()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ConcursDeDansDB")))
            {
                List<string> output = connection.Query<string>("dbo.selectCategory").ToList();
                return output;
            }
        }

        // Metoda ce preia denumirea tipurilor de dans
        public static List<string> GetDanceType()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ConcursDeDansDB")))
            {
                List<string> output = connection.Query<string>("dbo.selectDanceType").ToList();
                return output;
            }
        }

        // Metoda ce preia datele dansatorilor, in functie de codul introdus
        public static List<Dancer> GetDancersByCode(string code)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ConcursDeDansDB")))
            {
                List<Dancer> output = connection.Query<Dancer>($"dbo.selectDancersByCode @Code = '{code}'").ToList();
                return output;
            }
        }

        // Metoda ce determina cine s-a logat
        public static void WhoLogin(string username)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ConcursDeDansDB")))
            {
                connection.Execute($"CREATE OR ALTER VIEW currentUser (IdUser, Username, Parola, Email, EsteAdministrator)" +
                        $"AS SELECT * FROM Utilizatori WHERE Username = '{username}'");
            }
        }

        // Metoda ce selecteaza numele din vederea cu utilizatorul curent
        public static List<string> ViewLogin()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ConcursDeDansDB")))
            {
                List<string> output = connection.Query<string>("dbo.selectFromView").ToList();
                return output;
            }
        }

        // Metoda ce selecteaza numele administratorului logat
        public static List<string> GetAdministratorLogIn(string username, string parola)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ConcursDeDansDB")))
            {
                List<string> output = connection.Query<string>($"dbo.checkUser @Username = '{username}', @Parola = '{parola}'").ToList();
                return output;
            }
        }

        // Metoda ce inregistreaza un dansator nou
        public static void InsertDancer(string numeInstitutie, string adresaInstitutie, string denumireTipDans,
                                        string codDansator, string numeDansator, string prenumeDansator,
                                        string sexDansator, string dataNasterii, int experienta, string denumireConcurs,
                                        string email, string telefon, string adresaDansator)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ConcursDeDansDB")))
            {
                connection.Execute($"dbo.insertDancer @NumeInstitutie = '{numeInstitutie}', " +
                                   $"@AdresaInstitutie = '{adresaInstitutie}', " +
                                   $"@DenumireTipDans = '{denumireTipDans}', @CodDansator = '{codDansator}', " +
                                   $"@NumeDansator = '{numeDansator}', @PrenumeDansator = '{prenumeDansator}', " +
                                   $"@SexDansator = '{sexDansator}', @DataNasterii = '{dataNasterii}', " +
                                   $"@Experienta = {experienta}, @DenumireConcurs = '{denumireConcurs}', " +
                                   $"@Email = '{email}', @Telefon = '{telefon}', @AdresaDansator = '{adresaDansator}'");
            }
        }

        // Metoda ce insereaza premiul unui dansator
        public static void InsertPrize(string locul, int premiuBanesc, string denumireConcurs)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ConcursDeDansDB")))
            {
                connection.Execute($"dbo.insertPrize @Locul = '{locul}', @PremiuBanesc = {premiuBanesc}, @DenumireConcurs = '{denumireConcurs}'");
            }
        }

        // Metoda ce exclude un dansator
        public static void DeleteDancer(string cod)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ConcursDeDansDB")))
            {
                connection.Execute($"dbo.deleteDancer @CodDansator = '{cod}'");
            }
        }

        // Metoda ce preia datele celui mai tanar dansator
        public static List<Dancer> GetYoungestDancer()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ConcursDeDansDB")))
            {
                List<Dancer> output = connection.Query<Dancer>("dbo.youngestDancer").ToList();
                return output;
            }
        }

        // Metoda ce preia datele celui mai in varsta dansator
        public static List<Dancer> GetOldestDancer()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ConcursDeDansDB")))
            {
                List<Dancer> output = connection.Query<Dancer>("dbo.oldestDancer").ToList();
                return output;
            }
        }

        // Metoda ce preia codul, numele, prenumele si data nasterii dansatorilor
        // din toate concursurile, ordonati ascendent dupa varsta
        public static List<Dancer> GetSortedAscDancersByDate()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ConcursDeDansDB")))
            {
                List<Dancer> output = connection.Query<Dancer>("dbo.sortAscAllDancersByDate").ToList();
                return output;
            }
        }

        // Metoda ce preia codul, numele, prenumele si data nasterii dansatorilor
        // din concursul selectat, ordonati ascendent dupa varsta
        public static List<Dancer> GetSortedDancersAscFromOneCompetitionByDate(string denumireConcurs)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ConcursDeDansDB")))
            {
                List<Dancer> output = connection.Query<Dancer>($"dbo.sortDancersASCFromOneCompetitionByDate @DenumireConcurs = '{denumireConcurs}'").ToList();
                return output;
            }
        }

        // Metoda ce preia codul, numele, prenumele, data nasterii si sexul
        // cele mai tinere dansatoare de sex femenin
        public static List<Dancer> GetYoungestFemaleDancer()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ConcursDeDansDB")))
            {
                List<Dancer> output = connection.Query<Dancer>("dbo.youngestFemaleDancer").ToList();
                return output;
            }
        }

        // Metoda ce preia datele dansatorilor si denumirea categoriei,
        // in functie de categoria selectata
        public static List<Dancer> GetDancersByCategory(string categorie)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ConcursDeDansDB")))
            {
                List<Dancer> output = connection.Query<Dancer>($"dbo.selectDancersByCategory @DenumireCategorie ='{categorie}'").ToList();
                return output;
            }
        }

        // Metoda ce preia data nasterii dansatorilor barbati,
        // in functie de categoria selectata
        public static List<Dancer> GetMaleDancersByCategory(string categorie)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ConcursDeDansDB")))
            {
                List<Dancer> output = connection.Query<Dancer>($"dbo.selectMaleDancersByCategory @DenumireCategorie ='{categorie}'").ToList();
                return output;
            }
        }

        // Metoda ce ajuta la exportarea intr-un fisier MS Excel lista tuturor
        // participantelor cu varsta sub o varsta introdusa
        public static List<Dancer> GetFemaleDancersUnderIntroducedYears(string dataNasterii)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ConcursDeDansDB")))
            {
                List<Dancer> output = connection.Query<Dancer>($"dbo.selectFemaleDancersUnderIntroducedYears @DataIntrodusa ='{dataNasterii}'").ToList();
                return output;
            }
        }

        // Metoda ce creeaza o vedere ce contine date de contact al fiecarui dansator
        public static List<Dancer> CreateTableContactData()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ConcursDeDansDB")))
            {
                List<Dancer> output = connection.Query<Dancer>("dbo.createView").ToList();
                return output;
            }
        }

        // Metoda ce preia datele din vedere
        public static List<Dancer> GetViewContactData()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ConcursDeDansDB")))
            {
                List<Dancer> output = connection.Query<Dancer>("dbo.selectContactData").ToList();
                return output;
            }
        }

        // Metoda ce preia lista participantilor si institutia unde isi fac studiile
        public static List<Dancer> GetDancersAndInstitution()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ConcursDeDansDB")))
            {
                List<Dancer> output = connection.Query<Dancer>("dbo.selectDancersAndInstitution").ToList();
                return output;
            }
        }

        // Metoda ce ce apreia codul, numele, prenumele, locul dansatorului,
        // in functie de concursul selectat
        public static List<Dancer> GetDancerPrizeByCompetition(string denumireConcurs)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ConcursDeDansDB")))
            {
                List<Dancer> output = connection.Query<Dancer>($"dbo.selectDancerPrizeByCompetition @DenumireConcurs = '{denumireConcurs}'").ToList();
                return output;
            }
        }

        // Metoda ce preia numele, prenumele dansatorilor, in functie de concurs
        public static List<Dancer> GetDancersByCompetition(string competitionName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ConcursDeDansDB")))
            {
                List<Dancer> dancers = connection.Query<Dancer>($"dbo.selectDancersByCompetitionName @CompetitionName = '{competitionName}'").ToList();
                return dancers;
            }
        }
    }
}
