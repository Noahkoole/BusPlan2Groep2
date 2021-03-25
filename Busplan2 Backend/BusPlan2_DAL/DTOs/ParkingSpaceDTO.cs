﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BusPlan2_DAL.DTOs
{
    public class ParkingSpaceDTO
    {
        public int ParkingSpaceID { get; set; }
        public int BusID{ get; set; }
        public int Number { get; set; }
        public int Type { get; set; }
        public int Occupied { get; set; }

        public ParkingSpaceDTO(int parkingSpaceID, int busID, int number, int type, int occupied)
        {
            ParkingSpaceID = parkingSpaceID;
            BusID = busID;
            Number = number;
            Type = type;
            Occupied = occupied;
        }
    }
}
