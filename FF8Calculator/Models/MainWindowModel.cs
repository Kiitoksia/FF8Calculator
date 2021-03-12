using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models
{
    public class MainWindowModel : BaseModel
    {
        private EnemyModel source;


        public MainWindowModel()
        {
            Enemies = new List<EnemyModel>();

            // Doing it via reflection cause I am far too lazy to add these all myself
            foreach (Type enemyType in Assembly.GetAssembly(typeof(EnemyModel)).GetTypes().Where(t => t.IsClass && !t.IsAbstract && t.IsSubclassOf(typeof(EnemyModel))))
            {
                Enemies.Add((EnemyModel)Activator.CreateInstance(enemyType));
            }

            Enemies = Enemies.OrderBy(t => t.ID).ToList();

            PhysicalDamage = new PhysicalDamageModel();            
            MagicDamage = new MagicDamageModel();
            LevelCalculator = new LevelCalculatorModel();

            LevelCalculator.PropertyChanged += LevelCalculator_PropertyChanged;
        }

        private void LevelCalculator_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (Source != null)
            {
                Source.CalculateStats(LevelCalculator.AverageLevel);
            }
        }

        public List<EnemyModel> Enemies { get; }

        public EnemyModel Source
        {
            get => source; set
            {
                if (source == value)
                    return;
                source = value;                
                OnPropertyChanged();
            }
        }

        public PhysicalDamageModel PhysicalDamage { get; }

        public LevelCalculatorModel LevelCalculator { get; }
        public MagicDamageModel MagicDamage { get; }
    }
}
