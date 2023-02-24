
using AthleteEntity.Data;
using AthleteEntity.Data.Models;

namespace AthleteEntity
{


    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Athlete athobj = new Athlete() { FullName ="Usain Bolt", Sport = "Track and Field", CoachId = 1};

            using(SportManagerDbContext context= new SportManagerDbContext())
            {
                context.Athletes.Add(athobj);
                context.SaveChanges();
            }

        }
    }
}