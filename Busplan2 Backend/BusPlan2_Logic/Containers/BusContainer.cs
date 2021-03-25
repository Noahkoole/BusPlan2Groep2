using System;
using System.Collections.Generic;
using System.Text;
using BusPlan2_DAL.Handlers;

namespace BusPlan2_Logic.Containers
{
    public class BusContainer
    {
        public void Create()
        {

        }

        public void Read()
        {

        }

        public void Delete()
        {

        }

        public bool UpdateStatus(int busNumber, int status)
        {
            BusHandler handler = new BusHandler();

            return (handler.UpdateStatus(busNumber, status));
        }
    }
}
