using AirportManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Services.Interfaces
{
    internal interface ICapacityService
    {
        List<Capacity> GetAllCapacity();
        void AddCapacity(Capacity capacity);
        void UpdateCapacity(Capacity capacityBeforeChanges, string description);
        void DeleteCapacity(Capacity capacity);
    }
}
