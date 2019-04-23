namespace MortalEngines.Core
{
    using MortalEngines.Common;
    using MortalEngines.Core.Contracts;
    using MortalEngines.Entities.Contracts;
    using System.Collections.Generic;
    using System.Linq;

    public class MachinesManager : IMachinesManager
    {
        private List<IMachine> machines;
        private List<IPilot> pilots;
        private IMachineFactory machineFactory;
        private IPilotFactory pilotFactory;

        public MachinesManager(IMachineFactory machineFactory, IPilotFactory pilotFactory)
        {
            this.machines = new List<IMachine>();
            this.pilots = new List<IPilot>();
            this.machineFactory = machineFactory;
            this.pilotFactory = pilotFactory;
        }

        public string AttackMachines(string attackingMachineName, string defendingMachineName)
        {
            IMachine attacker = this.machines.FirstOrDefault(x => x.Name == attackingMachineName);
            IMachine defender = this.machines.FirstOrDefault(x => x.Name == defendingMachineName);

            if (!CheckIfMachineExists(attackingMachineName))
            {
                return string.Format(OutputMessages.MachineNotFound, attackingMachineName);
            }
            
            if (!CheckIfMachineExists(defendingMachineName))
            {
                return string.Format(OutputMessages.MachineNotFound, defendingMachineName);
            }

            if (CheckIfDead(attacker))
            {
                return string.Format(OutputMessages.DeadMachineCannotAttack, attacker.Name);
            }

            if (CheckIfDead(defender))
            {
                return string.Format(OutputMessages.DeadMachineCannotAttack, defender.Name);
            }

            attacker.Attack(defender);

            return string.Format(OutputMessages.AttackSuccessful, defender.Name, attacker.Name, defender.HealthPoints);
        }

        public string EngageMachine(string selectedPilotName, string selectedMachineName)
        {
            if (!CheckIfPilotExists(selectedPilotName))
            {
                return string.Format(OutputMessages.PilotNotFound, selectedPilotName);
            }
            if (!CheckIfMachineExists(selectedMachineName))
            {
                return string.Format(OutputMessages.MachineNotFound, selectedMachineName);
            }

            IPilot pilot = GetPilot(selectedPilotName);
            IMachine machine = GetMachine(selectedMachineName);

            if (!CheckIfNull(machine.Pilot))
            {
                return string.Format(OutputMessages.MachineHasPilotAlready, selectedMachineName);
            }

            machine.Pilot = pilot;
            pilot.AddMachine(machine);

            return string.Format(OutputMessages.MachineEngaged, pilot.Name, machine.Name);
        }

        public string HirePilot(string name)
        {
            if (CheckIfPilotExists(name))
            {
                return string.Format(OutputMessages.PilotExists, name);
            }

            IPilot pilot = this.pilotFactory.CreatePilot(name);
            this.pilots.Add(pilot);
            return string.Format(OutputMessages.PilotHired, pilot.Name);
        }

        public string ManufactureFighter(string name, double attackPoints, double defensePoints)
        {
            if (CheckIfMachineExists(name))
            {
                return string.Format(OutputMessages.MachineExists, name);
            }

            IMachine fighter = this.machineFactory.CreateFighter(name, attackPoints, defensePoints);
            this.machines.Add(fighter);

            return string.Format(OutputMessages.FighterManufactured, fighter.Name, fighter.AttackPoints, fighter.DefensePoints, "ON");
        }

        public string ManufactureTank(string name, double attackPoints, double defensePoints)
        {
            if (CheckIfMachineExists(name))
            {
                return string.Format(OutputMessages.MachineExists, name);
            }

            IMachine tank = this.machineFactory.CreateTank(name, attackPoints, defensePoints);
            this.machines.Add(tank);

            return string.Format(OutputMessages.TankManufactured, tank.Name, tank.AttackPoints, tank.DefensePoints);
        }

        public string PilotReport(string pilotName)
        {
            if (!CheckIfPilotExists(pilotName))
            {
                return string.Format(OutputMessages.PilotNotFound, pilotName);
            }

            return GetPilot(pilotName).Report();
        }

        public string MachineReport(string machineName)
        {
            if (!CheckIfMachineExists(machineName))
            {
                return string.Format(OutputMessages.MachineNotFound, machineName);
            }

            return GetMachine(machineName).ToString();
        }

        public string ToggleFighterAggressiveMode(string fighterName)
        {
            if (!CheckIfMachineExists(fighterName))
            {
                return string.Format(OutputMessages.MachineNotFound, fighterName);
            }

            IMachine machine = GetMachine(fighterName);

            if (!(machine is IFighter))
            {
                return string.Format(OutputMessages.MachineNotFound, fighterName);
            }
            else
            {
                IFighter fighter = machine as IFighter;
                fighter.ToggleAggressiveMode();
                return string.Format(OutputMessages.FighterOperationSuccessful, fighterName);
            }
        }

        public string ToggleTankDefenseMode(string tankName)
        {
            if (!CheckIfMachineExists(tankName))
            {
                return string.Format(OutputMessages.MachineNotFound, tankName);
            }

            IMachine machine = GetMachine(tankName);

            if (!(machine is ITank))
            {
                return string.Format(OutputMessages.MachineNotFound, tankName);
            }
            else
            {
                ITank tank = machine as ITank;
                tank.ToggleDefenseMode();
                return string.Format(OutputMessages.TankOperationSuccessful, tankName);
            }
        }

        private bool CheckIfMachineExists(string name)
        {
            return this.machines.Any(machine => machine.Name == name);
        }

        private IMachine GetMachine(string name)
        {
            return this.machines.FirstOrDefault(machine => machine.Name == name);
        }

        private bool CheckIfDead(IMachine machine)
        {
            return machine.HealthPoints == 0;
        }

        private bool CheckIfPilotExists(string name)
        {
            return this.pilots.Any(pilot => pilot.Name == name);
        }

        private IPilot GetPilot(string name)
        {
            return this.pilots.FirstOrDefault(pilot => pilot.Name == name);
        }

        private bool CheckIfNull(object entity)
        {
            return entity == null;
        }
    }
}
