using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndustrialMonitoring.Core.Entities;

namespace IndustrialMonitoring.Core.Interfaces
{
    public interface IDataCollectionService
    {
        Task<SensorReading> CollectDataAsync(string sensorId);
        Task<IEnumerable<SensorReading>> GetLatestReadingsAsync(int count = 100);
        Task<bool> SaveReadingAsync(SensorReading reading);
    }
}