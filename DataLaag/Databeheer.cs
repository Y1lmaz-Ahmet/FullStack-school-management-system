using BusinessLaag.exceptions;
using BusinessLaag.klassen;

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLaag
{
    public class Databeheer
    {
        private string connectionString;

        public Databeheer(string connectionString)
        {
            this.connectionString = connectionString;
        }
        private SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }

        public List<Leerling> haalLeerlingen()
        {
            throw new NotImplementedException();
        }

        public void UpdateLeerling(string rijksregisterNummer, Leerling leerling)
        {
            SqlConnection connection = GetConnection();
            string query = "UPDATE dbo.LeerlingSql SET Voornaam=@Voornaam, FamilieNaam=@FamilieNaam, Adres=@Adres," +
                " Email=@Email, GeboorteDatum=@GeboorteDatum, LeerJaar=@LeerJaar, KlasLokaal=@KlasLokaal," +
                " Functie=@Functie WHERE RijksregisterNummer=@RijksregisterNummer";
            using(SqlCommand command = new SqlCommand(query, connection))
            {
                //De eigenschap die gewijzigd kan worden.
                command.Parameters.AddWithValue("@Voornaam", leerling.Voornaam);
                command.Parameters.AddWithValue("@FamilieNaam", leerling.FamilieNaam);
                command.Parameters.AddWithValue("@Adres", leerling.Adres);
                command.Parameters.AddWithValue("@Email", leerling.Email);
                command.Parameters.AddWithValue("@GeboorteDatum", leerling.GeboorteDatum);
                command.Parameters.AddWithValue("@LeerJaar", leerling.LeerJaar);
                command.Parameters.AddWithValue("@KlasLokaal", leerling.KlasLokaal);
                command.Parameters.AddWithValue("@Functie", leerling.Functie);
                //De eigenschap waarmee het object kan worden geïdentificeerd om het vervolgens te kunnen bijwerken.
                command.Parameters.AddWithValue("@RijksregisterNummer", leerling.RijksregisterNummer);
                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if(rowsAffected == 0)
                    {
                        throw new AdministratiefMedewerkerException("Er werd geen rij geüpdatet voor het gegeven rijksregisternummer.");
                    }

                }catch(Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    connection.Close();
                    Console.WriteLine("[UpdateLeerling]: Student is aangepast.");
                }
            }
        }

        public void VerwijderStudent(string rijksregisterNummer)
        {
            using(SqlConnection connection = GetConnection())
            {
                string query = "delete from dbo.LeerlingSql where RijksregisterNummer = @RijksregisterNummer";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RijksregisterNummer", rijksregisterNummer);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();    
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                    finally
                    {
                        connection.Close();
                        Console.WriteLine("[VerwijderStudent]: student is verwijdert uit de databank.");
                    }
                }
            }
        }

        public void VoegStudentToe(Leerling leerling)
        {
            using (SqlConnection con = GetConnection())
            {
                string query = "INSERT INTO dbo.LeerlingSql (Voornaam, FamilieNaam, Adres, Email, RijksregisterNummer, GeboorteDatum, LeerJaar, KlasLokaal, Functie) " +
                               "VALUES (@Voornaam, @FamilieNaam, @Adres, @Email, @RijksregisterNummer, @GeboorteDatum, @LeerJaar, @KlasLokaal, @Functie)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Voornaam", leerling.Voornaam);
                    cmd.Parameters.AddWithValue("@FamilieNaam", leerling.FamilieNaam);
                    cmd.Parameters.AddWithValue("@Adres", leerling.Adres);
                    cmd.Parameters.AddWithValue("@Email", leerling.Email);
                    cmd.Parameters.AddWithValue("@RijksregisterNummer", leerling.RijksregisterNummer);
                    cmd.Parameters.AddWithValue("@GeboorteDatum", leerling.GeboorteDatum);
                    cmd.Parameters.AddWithValue("@LeerJaar", leerling.LeerJaar);
                    cmd.Parameters.AddWithValue("@KlasLokaal", leerling.KlasLokaal);
                    cmd.Parameters.AddWithValue("@Functie", leerling.Functie);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        con.Close();
                        Console.WriteLine("[VoegStudentToe]: student is toegevoegd in de databank.");
                    }
                }
            }
        }

        public Leerling ZoekLeerlingOpRijksregisterNummer(string rijksregisterNummer)
        {
            throw new NotImplementedException();
        }

       

        
    }
}
