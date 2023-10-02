using System;

namespace Volosyna_DZ4_4
{
    public abstract class GeographicObject
    {
        public double XCoordinate { get; set; }
        public double YCoordinate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual string GetInformation()
        {
            return $"Name: {Name}, Cooriante (X, Y): ({XCoordinate}, {YCoordinate}), Description: {Description}";
        }
    }

    public class River : GeographicObject
    {
        public double FlowSpeedCmPerSec { get; set; }
        public double TotalLength { get; set; }

        public override string GetInformation()
        {
            return base.GetInformation() + $", River's speed (sm/s): {FlowSpeedCmPerSec}, Total length: {TotalLength}";
        }
    }

    public class Mountain : GeographicObject
    {
        public double HighestPoint { get; set; }

        public override string GetInformation()
        {
            return base.GetInformation() + $", Highest point: {HighestPoint}";
        }
    }

    public interface IGeographicObject
    {
        string GetInformation();
    }
}