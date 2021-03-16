using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF8Calculator.Models
{
    public class StatCalculatorModel
    {
        public StatCalculatorModel()
        {
            Stats = new List<StatJunctionModel>();
            Stats.Add(new StatJunctionModel("Ultima", 60, 1.00m, 0.82m, 1.00m, 0.95m, 0.60m, 0.24m, 0.60m, 0.60m));
            Stats.Add(new StatJunctionModel("Full-life", 48, 0.20m, 0.80m, 0.20m, 0.85m, 0.08m, 0.04m, 0.08m, 0.20m));
            Stats.Add(new StatJunctionModel("Water", 3, 0.20m, 0.14m, 0.18m, 0.14m, 0.12m, 0.04m, 0.18m, 0.13m));
            Stats.Add(new StatJunctionModel("Aero", 3, 0.17m, 0.10m, 0.16m, 0.10m, 0.20m, 0.08m, 0.22m, 0.15m));
            Stats.Add(new StatJunctionModel("Esuna", 5, 0.06m, 0.36m, 0.12m, 0.36m, 0.03m, 0.02m, 0.03m, 0.10m));
            Stats.Add(new StatJunctionModel("Aura", 34, 0.70m, 0.22m, 0.24m, 0.24m, 0.10m, 0.02m, 0.50m, 0.40m));
            Stats.Add(new StatJunctionModel("Quake", 26, 0.40m, 0.20m, 0.40m, 0.20m, 0.07m, 0.03m, 0.30m, 0.12m));
            Stats.Add(new StatJunctionModel("Demi", 16, 0.34m, 0.18m, 0.36m, 0.18m, 0.12m, 0.04m, 0.14m, 0.10m));
            Stats.Add(new StatJunctionModel("Cure", 2, 0.04m, 0.15m, 0.04m, 0.15m, 0.03m, 0.02m, 0.02m, 0.02m));
            Stats.Add(new StatJunctionModel("Cura", 5, 0.08m, 0.28m, 0.08m, 0.28m, 0.04m, 0.02m, 0.03m, 0.03m));
            Stats.Add(new StatJunctionModel("Curaga", 22, 0.20m, 0.65m, 0.20m, 0.65m, 0.10m, 0.04m, 0.10m, 0.10m));
            Stats.Add(new StatJunctionModel("Confuse", 7, 0.22m, 0.18m, 0.28m, 0.18m, 0.18m, 0.04m, 0.08m, 0.08m));
            Stats.Add(new StatJunctionModel("Silence", 1, 0.06m, 0.05m, 0.12m, 0.10m, 0.04m, 0.02m, 0.03m, 0.02m));
            Stats.Add(new StatJunctionModel("Thunder", 1, 0.10m, 0.04m, 0.10m, 0.04m, 0.08m, 0.03m, 0.10m, 0.08m));
            Stats.Add(new StatJunctionModel("Thundara", 2, 0.15m, 0.08m, 0.15m, 0.08m, 0.12m, 0.04m, 0.16m, 0.12m));
            Stats.Add(new StatJunctionModel("Thundaga", 14, 0.30m, 0.16m, 0.30m, 0.16m, 0.14m, 0.04m, 0.20m, 0.14m));
            Stats.Add(new StatJunctionModel("Shell", 4, 0.06m, 0.18m, 0.10m, 0.40m, 0.03m, 0.02m, 0.03m, 0.14m));
            Stats.Add(new StatJunctionModel("Stop", 8, 0.18m, 0.20m, 0.30m, 0.24m, 0.48m, 0.10m, 0.20m, 0.10m));
            Stats.Add(new StatJunctionModel("Sleep", 1, 0.06m, 0.05m, 0.12m, 0.10m, 0.04m, 0.04m, 0.03m, 0.02m));
            Stats.Add(new StatJunctionModel("Slow", 5, 0.12m, 0.16m, 0.20m, 0.20m, 0.40m, 0.08m, 0.10m, 0.10m));
            Stats.Add(new StatJunctionModel("Zombie", 8, 0.15m, 0.24m, 0.15m, 0.12m, 0.02m, 0.01m, 0.02m, 0.02m));
            Stats.Add(new StatJunctionModel("Double", 2, 0.15m, 0.06m, 0.18m, 0.06m, 0.10m, 0.03m, 0.40m, 0.02m));
            Stats.Add(new StatJunctionModel("Death", 18, 0.22m, 0.22m, 0.38m, 0.58m, 0.10m, 0.04m, 0.10m, 0.38m));
            Stats.Add(new StatJunctionModel("Dispel", 10, 0.12m, 0.38m, 0.16m, 0.60m, 0.08m, 0.04m, 0.08m, 0.14m));
            Stats.Add(new StatJunctionModel("Triple", 24, 0.70m, 0.10m, 0.70m, 0.10m, 0.70m, 0.16m, 1.50m, 0.30m));
            Stats.Add(new StatJunctionModel("Tornado", 30, 0.48m, 0.24m, 0.42m, 0.24m, 0.33m, 0.13m, 0.38m, 0.14m));
            Stats.Add(new StatJunctionModel("Drain", 4, 0.13m, 0.30m, 0.20m, 0.24m, 0.06m, 0.02m, 0.05m, 0.04m));
            Stats.Add(new StatJunctionModel("Berserk", 3, 0.13m, 0.08m, 0.14m, 0.08m, 0.05m, 0.02m, 0.04m, 0.03m));
            Stats.Add(new StatJunctionModel("Bio", 7, 0.24m, 0.15m, 0.24m, 0.15m, 0.05m, 0.02m, 0.04m, 0.04m));
            Stats.Add(new StatJunctionModel("Fire", 1, 0.10m, 0.04m, 0.10m, 0.04m, 0.08m, 0.03m, 0.10m, 0.08m));
            Stats.Add(new StatJunctionModel("Fira", 2, 0.15m, 0.08m, 0.15m, 0.08m, 0.12m, 0.04m, 0.16m, 0.12m));
            Stats.Add(new StatJunctionModel("Firaga", 14, 0.30m, 0.16m, 0.30m, 0.16m, 0.14m, 0.04m, 0.20m, 0.14m));
            Stats.Add(new StatJunctionModel("Blind", 1, 0.06m, 0.05m, 0.12m, 0.10m, 0.03m, 0.02m, 0.30m, 0.02m));
            Stats.Add(new StatJunctionModel("Blizzard", 1, 0.10m, 0.04m, 0.10m, 0.04m, 0.08m, 0.03m, 0.10m, 0.08m));
            Stats.Add(new StatJunctionModel("Blizzara", 2, 0.15m, 0.08m, 0.15m, 0.08m, 0.12m, 0.04m, 0.16m, 0.12m));
            Stats.Add(new StatJunctionModel("Blizzaga", 14, 0.30m, 0.16m, 0.30m, 0.16m, 0.14m, 0.04m, 0.20m, 0.14m));
            Stats.Add(new StatJunctionModel("Flare", 32, 0.56m, 0.26m, 0.44m, 0.26m, 0.12m, 0.03m, 0.26m, 0.12m));
            Stats.Add(new StatJunctionModel("Break", 10, 0.20m, 0.20m, 0.34m, 0.35m, 0.10m, 0.04m, 0.10m, 0.12m));
            Stats.Add(new StatJunctionModel("Protect", 4, 0.06m, 0.40m, 0.10m, 0.18m, 0.03m, 0.02m, 0.03m, 0.14m));
            Stats.Add(new StatJunctionModel("Haste", 5, 0.12m, 0.16m, 0.20m, 0.20m, 0.50m, 0.08m, 0.10m, 0.10m));
            Stats.Add(new StatJunctionModel("Pain", 28, 0.42m, 0.38m, 0.60m, 0.45m, 0.04m, 0.01m, 0.04m, 0.40m));
            Stats.Add(new StatJunctionModel("Holy", 38, 0.55m, 0.28m, 0.45m, 0.48m, 0.10m, 0.07m, 0.24m, 0.14m));
            Stats.Add(new StatJunctionModel("Meteor", 46, 0.75m, 0.34m, 0.52m, 0.34m, 0.30m, 0.12m, 0.40m, 0.22m));
            Stats.Add(new StatJunctionModel("Meltdown", 15, 0.24m, 0.80m, 0.20m, 0.20m, 0.03m, 0.02m, 0.12m, 0.08m));
            Stats.Add(new StatJunctionModel("Scan", 1, 0.05m, 0.05m, 0.05m, 0.05m, 0.03m, 0.02m, 0.03m, 0.03m));
            Stats.Add(new StatJunctionModel("Regen", 26, 0.18m, 0.70m, 0.18m, 0.60m, 0.08m, 0.04m, 0.08m, 0.08m));
            Stats.Add(new StatJunctionModel("Reflect", 20, 0.14m, 0.46m, 0.20m, 0.72m, 0.10m, 0.04m, 0.08m, 0.16m));
            Stats.Add(new StatJunctionModel("Life", 12, 0.08m, 0.50m, 0.10m, 0.50m, 0.04m, 0.02m, 0.03m, 0.04m));
            Stats.Add(new StatJunctionModel("Float", 2, 0.08m, 0.15m, 0.08m, 0.15m, 0.16m, 0.04m, 0.12m, 0.20m));
            Stats.Add(new StatJunctionModel("Apocalypse", 42, 0.80m, 0.80m, 0.80m, 0.90m, 0.30m, 0.12m, 0.30m, 0.30m));
        }



        public List<StatJunctionModel> Stats { get; }

    }

}
