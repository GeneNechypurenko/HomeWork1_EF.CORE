using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    public class TrainService
    {
        private readonly TrainContext _context;

        public TrainService()
        {
            _context = new TrainContext();
            _context.Database.EnsureCreated();
        }

        public void AddTrain(Train train)
        {
            _context.Trains.Add(train);
            _context.SaveChanges();
        }

        public Train GetTrain(int trainId)
        {
            return _context.Trains.Find(trainId);
        }

        public void UpdateTrain(Train train)
        {
            _context.Entry(train).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteTrain(int trainId)
        {
            var train = _context.Trains.Find(trainId);
            if (train != null)
            {
                _context.Trains.Remove(train);
                _context.SaveChanges();
            }
        }
    }
}
