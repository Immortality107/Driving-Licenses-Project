using DVLDProject.DVLDData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDProject.DVLDBusiness
{
    internal class ClsTests
    {
        int TestAppointmentID = -1;
        bool TestResult = false;
        string Notes = "";
        int CreatedByUserID = -1;

        public static int AddTest(int TestAppointmentID, bool TestResult,
                               string Notes, int CreatedByUserID)
        {
            return TestsDataTier.AddTest(TestAppointmentID, TestResult, Notes, CreatedByUserID);

        }
        public static bool GetTestIDAndTestResult(int TestAppointmentID, ref int TestID, ref bool Passed)
        {

            return TestsDataTier.GetTestIDAndTestResult(TestAppointmentID, ref TestID, ref Passed);

        }
        public static bool PassedTest(int TestAppointmentID)
        {
            return TestsDataTier.PassedTest(TestAppointmentID);
        }
    }
}
