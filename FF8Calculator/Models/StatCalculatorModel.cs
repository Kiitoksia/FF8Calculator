using FF8Calculator.Models.Enemies;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models
{
    public class StatCalculatorModel : BaseModel
    {
        private int _level;
        private EnemyModel _player;

        public StatCalculatorModel()
        {
            Abilities = new List<StatJunctionModel>();
            Abilities.Add(new StatJunctionModel("Ultima", 60, 1.00m, 0.82m, 1.00m, 0.95m, 0.60m, 0.24m, 0.60m, 0.60m));
            Abilities.Add(new StatJunctionModel("Full-life", 48, 0.20m, 0.80m, 0.20m, 0.85m, 0.08m, 0.04m, 0.08m, 0.20m));
            Abilities.Add(new StatJunctionModel("Water", 3, 0.20m, 0.14m, 0.18m, 0.14m, 0.12m, 0.04m, 0.18m, 0.13m));
            Abilities.Add(new StatJunctionModel("Aero", 3, 0.17m, 0.10m, 0.16m, 0.10m, 0.20m, 0.08m, 0.22m, 0.15m));
            Abilities.Add(new StatJunctionModel("Esuna", 5, 0.06m, 0.36m, 0.12m, 0.36m, 0.03m, 0.02m, 0.03m, 0.10m));
            Abilities.Add(new StatJunctionModel("Aura", 34, 0.70m, 0.22m, 0.24m, 0.24m, 0.10m, 0.02m, 0.50m, 0.40m));
            Abilities.Add(new StatJunctionModel("Quake", 26, 0.40m, 0.20m, 0.40m, 0.20m, 0.07m, 0.03m, 0.30m, 0.12m));
            Abilities.Add(new StatJunctionModel("Demi", 16, 0.34m, 0.18m, 0.36m, 0.18m, 0.12m, 0.04m, 0.14m, 0.10m));
            Abilities.Add(new StatJunctionModel("Cure", 2, 0.04m, 0.15m, 0.04m, 0.15m, 0.03m, 0.02m, 0.02m, 0.02m));
            Abilities.Add(new StatJunctionModel("Cura", 5, 0.08m, 0.28m, 0.08m, 0.28m, 0.04m, 0.02m, 0.03m, 0.03m));
            Abilities.Add(new StatJunctionModel("Curaga", 22, 0.20m, 0.65m, 0.20m, 0.65m, 0.10m, 0.04m, 0.10m, 0.10m));
            Abilities.Add(new StatJunctionModel("Confuse", 7, 0.22m, 0.18m, 0.28m, 0.18m, 0.18m, 0.04m, 0.08m, 0.08m));
            Abilities.Add(new StatJunctionModel("Silence", 1, 0.06m, 0.05m, 0.12m, 0.10m, 0.04m, 0.02m, 0.03m, 0.02m));
            Abilities.Add(new StatJunctionModel("Thunder", 1, 0.10m, 0.04m, 0.10m, 0.04m, 0.08m, 0.03m, 0.10m, 0.08m));
            Abilities.Add(new StatJunctionModel("Thundara", 2, 0.15m, 0.08m, 0.15m, 0.08m, 0.12m, 0.04m, 0.16m, 0.12m));
            Abilities.Add(new StatJunctionModel("Thundaga", 14, 0.30m, 0.16m, 0.30m, 0.16m, 0.14m, 0.04m, 0.20m, 0.14m));
            Abilities.Add(new StatJunctionModel("Shell", 4, 0.06m, 0.18m, 0.10m, 0.40m, 0.03m, 0.02m, 0.03m, 0.14m));
            Abilities.Add(new StatJunctionModel("Stop", 8, 0.18m, 0.20m, 0.30m, 0.24m, 0.48m, 0.10m, 0.20m, 0.10m));
            Abilities.Add(new StatJunctionModel("Sleep", 1, 0.06m, 0.05m, 0.12m, 0.10m, 0.04m, 0.04m, 0.03m, 0.02m));
            Abilities.Add(new StatJunctionModel("Slow", 5, 0.12m, 0.16m, 0.20m, 0.20m, 0.40m, 0.08m, 0.10m, 0.10m));
            Abilities.Add(new StatJunctionModel("Zombie", 8, 0.15m, 0.24m, 0.15m, 0.12m, 0.02m, 0.01m, 0.02m, 0.02m));
            Abilities.Add(new StatJunctionModel("Double", 2, 0.15m, 0.06m, 0.18m, 0.06m, 0.10m, 0.03m, 0.40m, 0.02m));
            Abilities.Add(new StatJunctionModel("Death", 18, 0.22m, 0.22m, 0.38m, 0.58m, 0.10m, 0.04m, 0.10m, 0.38m));
            Abilities.Add(new StatJunctionModel("Dispel", 10, 0.12m, 0.38m, 0.16m, 0.60m, 0.08m, 0.04m, 0.08m, 0.14m));
            Abilities.Add(new StatJunctionModel("Triple", 24, 0.70m, 0.10m, 0.70m, 0.10m, 0.70m, 0.16m, 1.50m, 0.30m));
            Abilities.Add(new StatJunctionModel("Tornado", 30, 0.48m, 0.24m, 0.42m, 0.24m, 0.33m, 0.13m, 0.38m, 0.14m));
            Abilities.Add(new StatJunctionModel("Drain", 4, 0.13m, 0.30m, 0.20m, 0.24m, 0.06m, 0.02m, 0.05m, 0.04m));
            Abilities.Add(new StatJunctionModel("Berserk", 3, 0.13m, 0.08m, 0.14m, 0.08m, 0.05m, 0.02m, 0.04m, 0.03m));
            Abilities.Add(new StatJunctionModel("Bio", 7, 0.24m, 0.15m, 0.24m, 0.15m, 0.05m, 0.02m, 0.04m, 0.04m));
            Abilities.Add(new StatJunctionModel("Fire", 1, 0.10m, 0.04m, 0.10m, 0.04m, 0.08m, 0.03m, 0.10m, 0.08m));
            Abilities.Add(new StatJunctionModel("Fira", 2, 0.15m, 0.08m, 0.15m, 0.08m, 0.12m, 0.04m, 0.16m, 0.12m));
            Abilities.Add(new StatJunctionModel("Firaga", 14, 0.30m, 0.16m, 0.30m, 0.16m, 0.14m, 0.04m, 0.20m, 0.14m));
            Abilities.Add(new StatJunctionModel("Blind", 1, 0.06m, 0.05m, 0.12m, 0.10m, 0.03m, 0.02m, 0.30m, 0.02m));
            Abilities.Add(new StatJunctionModel("Blizzard", 1, 0.10m, 0.04m, 0.10m, 0.04m, 0.08m, 0.03m, 0.10m, 0.08m));
            Abilities.Add(new StatJunctionModel("Blizzara", 2, 0.15m, 0.08m, 0.15m, 0.08m, 0.12m, 0.04m, 0.16m, 0.12m));
            Abilities.Add(new StatJunctionModel("Blizzaga", 14, 0.30m, 0.16m, 0.30m, 0.16m, 0.14m, 0.04m, 0.20m, 0.14m));
            Abilities.Add(new StatJunctionModel("Flare", 32, 0.56m, 0.26m, 0.44m, 0.26m, 0.12m, 0.03m, 0.26m, 0.12m));
            Abilities.Add(new StatJunctionModel("Break", 10, 0.20m, 0.20m, 0.34m, 0.35m, 0.10m, 0.04m, 0.10m, 0.12m));
            Abilities.Add(new StatJunctionModel("Protect", 4, 0.06m, 0.40m, 0.10m, 0.18m, 0.03m, 0.02m, 0.03m, 0.14m));
            Abilities.Add(new StatJunctionModel("Haste", 5, 0.12m, 0.16m, 0.20m, 0.20m, 0.50m, 0.08m, 0.10m, 0.10m));
            Abilities.Add(new StatJunctionModel("Pain", 28, 0.42m, 0.38m, 0.60m, 0.45m, 0.04m, 0.01m, 0.04m, 0.40m));
            Abilities.Add(new StatJunctionModel("Holy", 38, 0.55m, 0.28m, 0.45m, 0.48m, 0.10m, 0.07m, 0.24m, 0.14m));
            Abilities.Add(new StatJunctionModel("Meteor", 46, 0.75m, 0.34m, 0.52m, 0.34m, 0.30m, 0.12m, 0.40m, 0.22m));
            Abilities.Add(new StatJunctionModel("Meltdown", 15, 0.24m, 0.80m, 0.20m, 0.20m, 0.03m, 0.02m, 0.12m, 0.08m));
            Abilities.Add(new StatJunctionModel("Scan", 1, 0.05m, 0.05m, 0.05m, 0.05m, 0.03m, 0.02m, 0.03m, 0.03m));
            Abilities.Add(new StatJunctionModel("Regen", 26, 0.18m, 0.70m, 0.18m, 0.60m, 0.08m, 0.04m, 0.08m, 0.08m));
            Abilities.Add(new StatJunctionModel("Reflect", 20, 0.14m, 0.46m, 0.20m, 0.72m, 0.10m, 0.04m, 0.08m, 0.16m));
            Abilities.Add(new StatJunctionModel("Life", 12, 0.08m, 0.50m, 0.10m, 0.50m, 0.04m, 0.02m, 0.03m, 0.04m));
            Abilities.Add(new StatJunctionModel("Float", 2, 0.08m, 0.15m, 0.08m, 0.15m, 0.16m, 0.04m, 0.12m, 0.20m));
            Abilities.Add(new StatJunctionModel("Apocalypse", 42, 0.80m, 0.80m, 0.80m, 0.90m, 0.30m, 0.12m, 0.30m, 0.30m));

            Players = new List<EnemyModel>();
            Players.Add(new Squall());
            Players.Add(new Zell());
            Players.Add(new Selphie());
            Players.Add(new Quistis());
            Players.Add(new Irvine());
            Players.Add(new Rinoa());
            Players.Add(new Edea());
            Players.Add(new Seifer());
            Players.Add(new Laguna());
            Players.Add(new Kiros());
            Players.Add(new Ward());

            Stats = new ObservableCollection<IndividualStatModel>();
            foreach (JunctionType junction in Enum.GetValues(typeof(JunctionType))) // Hooray for laziness instead of manually typing list
            {                
                IndividualStatModel.Create(this, junction);
            }

            PropertyChanged += (s, e) =>
            {
                if (_isCalculating) return;
                Calculate();
            };
        }

        private bool _isCalculating = false;

        private void Calculate()
        {
            _isCalculating = true;
            Player?.CalculateStats(Level);

            foreach (IndividualStatModel stat in Stats)
            {
                stat.Calculate(Player);
            }

            _isCalculating = false;
        }
        
        public int Level
        {
            get => _level; 
            set
            {
                if (_level == value)
                    return;
                _level = value;
                OnPropertyChanged();
            }
        }
        
        public EnemyModel Player
        {
            get => _player; 
            set
            {
                if (_player == value)
                    return;
                _player = value;
                OnPropertyChanged();
            }
        }

        public List<EnemyModel> Players { get; }        
        public List<StatJunctionModel> Abilities { get; }        
        public ObservableCollection<IndividualStatModel> Stats { get; }
    }

}
