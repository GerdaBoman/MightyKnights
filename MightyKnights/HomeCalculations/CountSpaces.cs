﻿using DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.HomeCalculations
{
    public class CountSpaces
    {
        public int CountFullSpaces()
        {
            using(var db = new MightyKnightsContext())
            {
                var carSpaces = (from p in db.ParkingLots
                                  join v in db.Vehicles on p.VehicleId equals v.VehicleId
                                  where v.Size == 4
                                  select p.SpotNumber).Count();

                var mCSpaces = (from p in db.ParkingLots
                                join v in db.Vehicles on p.VehicleId equals v.VehicleId
                                where v.Size == 2 
                                select p.SpotNumber).ToList();

                var fullMcSpaces = mCSpaces.GroupBy(x => x)
                                    .Where(g => g.Count() > 1)
                                    .Select(y => y.Key).Count();


                int fullSpaces = carSpaces + fullMcSpaces;

                return fullSpaces;

            }
        }
        public int CountPartialSpaces()
        {
            using(var db = new MightyKnightsContext())
            {
                var mCSpaces = (from p in db.ParkingLots
                                join v in db.Vehicles on p.VehicleId equals v.VehicleId
                                where v.Size == 2
                                select new
                                {
                                    Vehile = v.VehicleId,
                                    ParkingSpot = p.SpotNumber
                                }).ToList(); 
             

                var fullMcSpaces = mCSpaces.GroupBy(x => x.ParkingSpot)
                                    .Where(x=> x.Count() > 1)
                                    .Select(y => y.Key).Count();

                //int partialSpaces = mCSpaces.Count() - fullMcSpaces;

                int partialSpaces = mCSpaces.GroupBy(x => x.ParkingSpot)
                                    .Where(x => x.Count() == 1)
                                    .Select(mCSpaces => mCSpaces.Key).Count();


                return partialSpaces;

            }
        }

        public int CountAllTakenSpaces()
        {
            int fullSpots = CountFullSpaces();
            int partialSpaces = CountPartialSpaces();

            int allTakenSpaces = fullSpots + partialSpaces;

            return allTakenSpaces;
        }
    }
}
