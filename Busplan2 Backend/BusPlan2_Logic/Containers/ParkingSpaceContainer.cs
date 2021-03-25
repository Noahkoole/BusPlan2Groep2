using System;
using System.Collections.Generic;
using System.Text;
using BusPlan2_DAL.DTOs;
using BusPlan2_DAL.Handlers;

namespace BusPlan2_Logic.Containers
{
    public class ParkingSpaceContainer
    {
        public void Create()
        {

        }

        public void Read()
        {

        }

        public void Update(ParkingSpaceDTO ParkingSpace) 
        {
            ParkingSpaceHandler handler = new ParkingSpaceHandler();

            handler.Update(ParkingSpace);
        }

        public void Delete()
        {

        }
    }
}
