using DVLDProject.DVLDData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDProject.DVLDBusiness
{
    internal class ClsTestAppointments
    {
        int AppointmentID = -1;
        int TestTypeID = -1;
        int LDLAppID = -1;
        DateTime AppointmentDate = DateTime.MinValue;
        decimal PaidFees = 0;
        int CreatedByUserID = -1;
        bool IsLocked = false;
        int RetakeTestAppointmentID = 0;

        public static int AddAppointment(int TestTypeID, int LDLAppID, DateTime AppointmentDate,
                                        decimal PaidFees, int CreatedByUserID, bool IsLocked)
        {
            return TestAppointmentsDataTier.AddNewTestAppointment(TestTypeID, LDLAppID, AppointmentDate, PaidFees,
                CreatedByUserID, IsLocked);
        }

        public static DataTable GetAppointmentsWithLDLAppID(int LDLAppID, int TestTypeID)
        {
            return TestAppointmentsDataTier.GetAppointmentsWithLDLAppID(LDLAppID, TestTypeID);
        }

        public static bool LockTestAppointment(int LDLAppID)
        {
            return TestAppointmentsDataTier.LockTestAppointmentAfterTest(LDLAppID);
        }

        public static bool AddRetakeTestApplicationID(int TestAppointmentID, int RetakeTestApplicationID)
        {
            return TestAppointmentsDataTier.AddRetakeTestApplicationID(TestAppointmentID, RetakeTestApplicationID);
        }
        public static bool UpdateAppointmentDate(int TestAppointmentID, DateTime NewDate)
        {
            return TestAppointmentsDataTier.UpdateAppointmentDate(TestAppointmentID, NewDate);
        }
    }
}