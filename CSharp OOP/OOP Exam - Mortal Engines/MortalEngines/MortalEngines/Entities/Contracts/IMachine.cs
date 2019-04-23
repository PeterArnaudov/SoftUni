﻿using System.Collections.Generic;

namespace MortalEngines.Entities.Contracts
{
    public interface IMachine
    {
        string Name { get; }

        IPilot Pilot { get; set; }

        double HealthPoints { get; set; }

        double AttackPoints { get; }

        double DefensePoints { get; }

        IReadOnlyCollection<string> Targets { get; }

        void Attack(IMachine target);
    }
}
