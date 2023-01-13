using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qc_Lab.Services.Interfaces
{
   public interface ITestServices
    {
        void AddTest(string testName, int deviceId, int countEnterValue, float minOkValue, 
            float maxOkValue, string EnterVal1, string EnterVal2, string EnterVal3, 
            string EnterVal4, string EnterVal5, string EnterVal6, string EnterVal7, 
            string EnterVal8, string EnterVal9, string EnterVal10, string EnterVal11, 
            string EnterVal12, string formula);
        DataSet FillDevice();
        DataTable GetAllTest();
        DataTable GetTestByDeviceId(int deviceId);
        void TestDelete(int testId);
        OleDbDataReader FindTestById(int testId);

        #region Device
        DataTable GetAllDevais();
        void AddDevaice(string name, string model, int createYear, int yearUse, bool isActive, string description);
        void EditDevaice(string name, string model, int createYear, int yearUse, bool isActive, string description,int deviceId);
        OleDbDataReader FindDeviceById(int deviceId);
        void AddTesting(int userId, int deviceId, int testId, string FormolaString, string FormulaAfterCheck, string lastNumber, string TestDate);
        #endregion
    }
}
