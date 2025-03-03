using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using DVLDProject.DVLDData;
namespace DVLDProject.DVLDBusiness
{

    public class clsDriver
    {
        int DriverID = -1;
        int PersonID = -1;
        int CreatedByUserID = -1;
        DateTime CreationDate = DateTime.Now;



        public clsDriver()
        {
            this.DriverID = -1;
            this.PersonID = -1;
            this.CreatedByUserID = -1;
            this.CreationDate = DateTime.Now;
        }

        private clsDriver(int DriverID, int PersonID, int CreatedbyUserID, DateTime CreationDate)
        {
            this.DriverID = DriverID;
            this.PersonID = PersonID;
            this.CreatedByUserID = CreatedbyUserID;
            this.CreationDate = CreationDate;
        }

        public static DataTable GetAllDrivers()
        {
         
                return DriverDataTier.GetAllDrivers();
        }
        public static int GetDriverIDWithPersonID(int PersonID) {
        return DriverDataTier.GetDriverIDWithPersonID(PersonID);
        
        }
        public static int GetPersonIDWithDriverID(int DriverID)
        {
            return DriverDataTier.GetPersonIDWithDriverID(DriverID);

        }

        public static int AddNewDriver(int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            return DriverDataTier.AddNewDriver(PersonID, CreatedByUserID, CreatedDate);

        }
    }
}





