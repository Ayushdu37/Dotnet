using System;
using System.Collections.Generic;
using System.Linq;

namespace AutonomousRobot.AI
{
    public class DecisionEngine
    {
        public List<SensorReading> GetRecentReadings(List<SensorReading> sensorHistory, DateTime fromTime)
        {
            return sensorHistory.Where(r => r.Timestamp >= fromTime).ToList();
        }
        public bool IsBatteryCritical(List<SensorReading> readings)
        {
            return readings.Any(r => r.Type == "Battery" && r.Value < 20);
        }
        public double GetNearestObstacleDistance(List<SensorReading> readings)
        {
            var distanceReadings = readings.Where(r => r.Type == "Distance");
            if (!distanceReadings.Any()) return double.MaxValue;
            return distanceReadings.Min(r => r.Value);
        }
        public bool IstemperatureSafe(List<SensorReading> readings)
        {
            return readings.Where(r => r.Type == "Temperature").All(r => r.Value < 90);
        }
        public double GetAverageVibration(List<SensorReading> readings)
        {
            var vibrationReadings = readings.Where(r => r.Type == "Vibration").Select(r => r.Value);

            int count = vibrationReadings.Count();

            if (count == 0) return 0;

            double sum = vibrationReadings.Sum();

            return sum / count;
        }
        public Dictionary<string, double> CalculateSensorHealth(List<SensorReading> sensorHistory)
        {
            Dictionary<string, double> result = new Dictionary<string, double>();

            var groupedSensors = sensorHistory.GroupBy(r => r.Type);

            foreach (var group in groupedSensors)
            {
                double sum = group.Sum(r => r.Confidence);
                int count = group.Count();

                if (count > 0)
                {
                    result[group.Key] = sum / count;
                }
            }

            return result;
        }
        public List<string> DetectFaultySensors(List<SensorReading> sensorHistory)
        {
            return sensorHistory.Where(r => r.Confidence < 0.4).GroupBy(r => r.Type).Where(g => g.Count() > 2).Select(g => g.Key).ToList();
        }
        public double GetWeightedDistance(List<SensorReading> readings)
        {
            var distanceReadings =  readings.Where(r => r.Type == "Distance");

            double totalConfidence = readings.Sum(r => r.Confidence);

            if(totalConfidence == 0)
            {
                return double.MaxValue;
            }

            double weightedSum = distanceReadings.Sum(r => r.Value * r.Confidence);

            return weightedSum / totalConfidence;
        }
        public RobotAction DecideRobotAction(List<SensorReading> recentReadings, List<SensorReading> sensorHistory)
        {
            
        }

    }
}