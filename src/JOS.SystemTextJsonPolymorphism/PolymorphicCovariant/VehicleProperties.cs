﻿namespace JOS.SystemTextJsonPolymorphism.PolymorphicCovariant
{
    public abstract class VehicleProperties
    {
        protected VehicleProperties(int wheels, int passengers)
        {
            Wheels = wheels;
            Passengers = passengers;
        }

        public int Wheels { get; }
        public int Passengers { get; }
    }
}
