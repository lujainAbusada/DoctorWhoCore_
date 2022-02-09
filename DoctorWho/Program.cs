using DoctorWho.Db;
using DoctorWho.Db.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DoctorWho
{
    class Program
    {
        private static DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();
        static void Main(string[] args)
        {
        }

        private static void ViewEpisodes()
        {
            var stats = _context.ViewEpisodes.ToList();
            Console.WriteLine(stats.ElementAt(0).AuthorId);
        }

        private static List<IFrequentCharacters> ExecutespSummariseEpisodes()
        {
            List<IFrequentCharacters> frequentCharacters = new List<IFrequentCharacters>();

            using (var command = _context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "spSummariseEpisodes";
                command.CommandType = CommandType.StoredProcedure;
                _context.Database.OpenConnection();
                var dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    int companionId = dataReader.GetInt32(dataReader.GetOrdinal("CompanionId"));
                    int frequency = dataReader.GetInt32(dataReader.GetOrdinal("number"));
                    frequentCharacters.Add(new FrequentCompanion { CompanionId = companionId, Frequency = frequency });
                }
                dataReader.NextResult();
                while (dataReader.Read())
                {
                    int enemyId = dataReader.GetInt32(dataReader.GetOrdinal("EnemyId"));
                    int frequency = dataReader.GetInt32(dataReader.GetOrdinal("number"));
                    frequentCharacters.Add(new FrequentEnemy { EnemyId = enemyId, Frequency = frequency });
                }
            }
            return frequentCharacters;
        }
    }
}
