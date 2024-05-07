using AC4.Persistence.Utils;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaveTheOcean2.Persistence.DAO;
using SaveTheOcean2.Models;

namespace AC4.Persistence.Mapping
{
    public class RescueDAO : IRescueDAO
    {
       
         private readonly string connectionString;

         public RescueDAO(string connectionString)
         {
         this.connectionString = connectionString;
         }


         public void AddRescue(Rescue record)
         {
         using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
         {
              connection.Open();
              using (NpgsqlCommand command = new NpgsqlCommand("INSERT INTO Rescue (IdRescue, Date, Location, GA, AnimalBreed, AnimalName, AnimalWeight, AnimalSuperfamily)VALUES(@IdRescue, @Date, @Location, @GA, @AnimalBreed, @AnimalName, @AnimalWeight, @AnimalSuperfamily);", connection))
              {
                    command.Parameters.AddWithValue("@IdRescue", record.IdRescue);
                    command.Parameters.AddWithValue("@Date", record.Date);
                    command.Parameters.AddWithValue("@Location", record.Location);
                    command.Parameters.AddWithValue("@GA", record.GA);
                    command.Parameters.AddWithValue("@AnimalBreed", record.Animal.Breed);
                    command.Parameters.AddWithValue("@AnimalName", record.Animal.Name);
                    command.Parameters.AddWithValue("@AnimalWeight", record.Animal.Weight);
                    command.Parameters.AddWithValue("@AnimalSuperfamily", record.Animal.SuperFamily);
                    command.ExecuteNonQuery();
                    }
         }
                
         }  
         public List<Rescue> GetRescues()
         {
              List<Rescue> rescues = new List<Rescue>();
              using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
              {
                    connection.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM Rescue;", connection))
                    {
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Rescue rescue = new Rescue();
                                rescue.IdRescue = reader.GetString(0);
                                rescue.Date = reader.GetDateTime(1);
                                rescue.Location = reader.GetString(2);
                                rescue.GA = reader.GetInt32(3);
                                rescue.Animal.Breed = reader.GetString(4);
                                rescue.Animal.Name = reader.GetString(5);
                                rescue.Animal.Weight = reader.GetFloat(6);
                                rescue.Animal.SuperFamily = reader.GetString(7);
                                rescues.Add(rescue);
                            }
                        }
                    }
                }
                return rescues;
        }
        public List<Rescue> GetRescueById(string id)
        {

            Rescue rescue = new Rescue();
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM Rescue WHERE IdRescue = @IdRescue;", connection))
                {
                    command.Parameters.AddWithValue("@IdRescue", id);
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            rescue.IdRescue = reader.GetString(0);
                            rescue.Date = reader.GetDateTime(1);
                            rescue.Location = reader.GetString(2);
                            rescue.GA = reader.GetInt32(3);
                            rescue.Animal.Breed = reader.GetString(4);
                            rescue.Animal.Name = reader.GetString(5);
                            rescue.Animal.Weight = reader.GetFloat(6);
                            rescue.Animal.SuperFamily = reader.GetString(7);
                        }
                    }
                }
            }
            List<Rescue> rescues = new List<Rescue>();
            rescues.Add(rescue);
            return rescues;
        }

        
    }
}
