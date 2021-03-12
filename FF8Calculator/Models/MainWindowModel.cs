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

        private EnemyModel _averageLevelEnemy;
        private EnemyModel _highLevelEnemy;
        private EnemyModel _lowLevelEnemy;
        private EnemyModel _source;
        private LevelSelect _levelSelect = LevelSelect.High;

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
            RecalculateAllStats();
        }

        private void RecalculateAllStats()
        {
            if (Source == null)
            {
                LowLevelEnemy?.CalculateStats(0);
                AverageLevelEnemy?.CalculateStats(0);
                HighLevelEnemy?.CalculateStats(0);
            }
            else
            {
                LowLevelEnemy.CalculateStats(LevelCalculator.LowLevel);
                AverageLevelEnemy.CalculateStats(LevelCalculator.AverageLevel);
                HighLevelEnemy.CalculateStats(LevelCalculator.HighLevel);
            }
        }

        public EnemyModel AverageLevelEnemy
        {
            get => _averageLevelEnemy;
            private set
            {
                if (_averageLevelEnemy == value)
                    return;
                _averageLevelEnemy = value;
                OnPropertyChanged();
            }
        }

        public List<EnemyModel> Enemies { get; }
        public EnemyModel HighLevelEnemy
        {
            get => _highLevelEnemy;
            private set
            {
                if (_highLevelEnemy == value)
                    return;
                _highLevelEnemy = value;
                OnPropertyChanged();
            }
        }

        public LevelCalculatorModel LevelCalculator { get; }
        public EnemyModel LowLevelEnemy
        {
            get => _lowLevelEnemy;
            private set
            {
                if (_lowLevelEnemy == value)
                    return;
                _lowLevelEnemy = value;
                OnPropertyChanged();
            }
        }

        private void SyncDamageModelEnemies()
        {
            switch (LevelSelect)
            {
                case LevelSelect.Low:
                    PhysicalDamage.Target = LowLevelEnemy;
                    break;
                case LevelSelect.Average:
                    PhysicalDamage.Target = AverageLevelEnemy;
                    break;
                case LevelSelect.High:
                    PhysicalDamage.Target = HighLevelEnemy;
                    break;
            }
        }

        public LevelSelect LevelSelect
        {
            get => _levelSelect; 
            set
            {
                if (_levelSelect == value)
                    return;
                _levelSelect = value;
                OnPropertyChanged();
                SyncDamageModelEnemies();                
            }
        }

        public MagicDamageModel MagicDamage { get; }

        public PhysicalDamageModel PhysicalDamage { get; }

        public EnemyModel Source
        {
            get => _source; set
            {
                if (_source == value)
                    return;
                _source = value;

                LowLevelEnemy = value?.Clone();
                AverageLevelEnemy = value?.Clone();
                HighLevelEnemy = value?.Clone();
                RecalculateAllStats();
                SyncDamageModelEnemies();
                OnPropertyChanged();
            }
        }

    }
}
