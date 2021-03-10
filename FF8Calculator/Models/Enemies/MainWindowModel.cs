using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models.Enemies
{
    public class MainWindowModel : BaseModel
    {
        public MainWindowModel()
        {
            Enemies = new List<EnemyModel>();

            // Doing it via reflection cause I am far too lazy to add these all myself
            foreach (Type enemyType in Assembly.GetAssembly(typeof(EnemyModel)).GetTypes().Where(t => t.IsClass && !t.IsAbstract && t.IsSubclassOf(typeof(EnemyModel))))
            {
                Enemies.Add((EnemyModel)Activator.CreateInstance(enemyType));
            }

            Enemies = Enemies.OrderBy(t => t.ID).ToList();
        }

        public List<EnemyModel> Enemies { get; }
    }
}
