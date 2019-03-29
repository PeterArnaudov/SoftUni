namespace TrafficLights
{
    using System;

    public class TrafficLight
    {
        private Signals signal;

        public TrafficLight(string signal)
        {
            this.Signal = Enum.Parse<Signals>(signal);
        }

        public Signals Signal
        {
            get => this.signal;

            private set => this.signal = value;
        }

        public void Change()
        {
            this.Signal++;

            if ((int)this.Signal == 3)
            {
                Signal = 0;
            }
        }

        public override string ToString()
        {
            return this.Signal.ToString();
        }
    }
}
