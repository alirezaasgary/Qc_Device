using Qc_Lab.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Qc_Lab.Utilities;
using System.Data.OleDb;
using System.Data;

namespace Qc_Lab.Services
{
    public class TestServices : ITestServices
    {
        public void AddDevaice(string name, string model, int createYear, int yearUse, bool isActive, string description)
        {
            string query = "INSERT INTO  [Devaic](Name,Model,CreateYear,YearUse,isActive,Description)" +
                "Select '"+name+ "','" + model+ "',"+createYear+","+yearUse+","+isActive+",'"+description+"'";
            OleDbConnection Connection = new OleDbConnection(StaticParametr.connectionString);
            OleDbCommand odc = new OleDbCommand(query, Connection);
            Connection.Open();
            odc.ExecuteNonQuery();
            Connection.Close();
        }

        

        public void AddTest(string testName, int deviceId, int countEnterValue, float minOkValue, float maxOkValue, string EnterVal1, string EnterVal2, string EnterVal3, string EnterVal4, string EnterVal5, string EnterVal6, string EnterVal7, string EnterVal8, string EnterVal9, string EnterVal10, string EnterVal11, string EnterVal12, string formula)
        {
            string query = "INSERT INTO  [TestTable] (testName,deviceId,countEnterValue,minOkValue,maxOkValue,EnterVal1,EnterVal2,EnterVal3,EnterVal4,EnterVal5,EnterVal6,EnterVal7,EnterVal8,EnterVal9,EnterVal10,EnterVal11,EnterVal12,formula) " +
               "select '" + testName + "'," + deviceId + "," + countEnterValue + "," + minOkValue + "," + maxOkValue + ",'" + EnterVal1 + "','" + EnterVal2 + "','" + EnterVal3 + "','" + EnterVal4 + "','" + EnterVal5 + "','" + EnterVal6 + "','" + EnterVal7 + "','" + EnterVal8 + "','" + EnterVal9 + "','" + EnterVal10 + "','" + EnterVal11 + "','" + EnterVal12 + "','" + formula + "'";
            OleDbConnection Connection = new OleDbConnection(StaticParametr.connectionString);
            OleDbCommand odc = new OleDbCommand(query, Connection);
            Connection.Open();
            odc.ExecuteNonQuery();
            Connection.Close();
    
        }

        public void AddTesting(int userId, int deviceId, int testId, string FormolaString, string FormulaAfterCheck, string lastNumber, string TestDate)
        {
            string query = "INSERT INTO  [Testing] (TestUserId,TestId,DeviceId,FormolaString,FormulaAfterCheck,lastNumber,TestDate) " +
              "select " + userId + "," + deviceId + "," + testId + ",'" + FormolaString + "','" + FormulaAfterCheck + "','" + lastNumber + "','" + TestDate + "'";
            OleDbConnection Connection = new OleDbConnection(StaticParametr.connectionString);
            OleDbCommand odc = new OleDbCommand(query, Connection);
            Connection.Open();
            odc.ExecuteNonQuery();
            Connection.Close();
        }

        public void EditDevaice(string name, string model, int createYear, int yearUse, bool isActive, string description, int deviceId)
        {
            string query = "update [Devaic] set Name ='" + name + "' , Model='" + model + "' , CreateYear =" + createYear + " , YearUse=" + yearUse + " , isActive=" + isActive + ", Description='" + description + "' where deviceId=" + deviceId + " ";
            OleDbConnection Connection = new OleDbConnection(StaticParametr.connectionString);
            OleDbCommand odc = new OleDbCommand(query, Connection);
            Connection.Open();
            odc.ExecuteNonQuery();
            Connection.Close();
        }

        public DataSet FillDevice()
        {

            string query = "select DeviceId,Name from [Devaic]";
            OleDbConnection Connection = new OleDbConnection( StaticParametr.connectionString);
            OleDbCommand cmd = new OleDbCommand(query, Connection);
            OleDbDataAdapter da = new OleDbDataAdapter(query, Connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Connection.Open();
            cmd.ExecuteNonQuery();
            Connection.Close();
            return ds;

        
        }

        public OleDbDataReader FindDeviceById(int deviceId)
        {
            string query = "select * from [devaic] where DeviceId =" + deviceId + "";
            OleDbConnection Connection = new OleDbConnection(StaticParametr.connectionString);
            OleDbCommand topiccmd = new OleDbCommand(query, Connection);
            Connection.Open();
            OleDbDataReader dr = topiccmd.ExecuteReader();

            return dr;

        }

        public OleDbDataReader FindTestById(int testId)
        {
            string query = "select * from [TestTable] where TestId =" + testId + "";
            OleDbConnection Connection = new OleDbConnection(StaticParametr.connectionString);
            OleDbCommand topiccmd = new OleDbCommand(query, Connection);
            Connection.Open();
            OleDbDataReader dr = topiccmd.ExecuteReader();

            return dr;

        }

        public DataTable GetAllDevais()
        {
            string query = "SELECT * from Devaic ";
            OleDbConnection connection = new OleDbConnection(StaticParametr.connectionString);
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public DataTable GetAllDevais(string name, string model, int createYear, int yearUse, bool isActive, string description)
        {
            throw new NotImplementedException();
        }

        public DataTable GetAllTest()
        {
            string query = "SELECT TestTable.TestId, TestTable.testName,Devaic.Name,TestTable.countEnterValue,TestTable.minOkValue,TestTable.maxOkValue,TestTable.formula " +
                           " FROM     (TestTable INNER JOIN" +
                           "                  Devaic ON Devaic.DeviceId = TestTable.DeviceId) ";
            OleDbConnection connection = new OleDbConnection(StaticParametr.connectionString);
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public DataTable GetTestByDeviceId(int deviceId)
        {
            string query = "Select * from [TestTable] where DeviceId=" + deviceId;
            OleDbConnection connection = new OleDbConnection(StaticParametr.connectionString);
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public void TestDelete(int testId)
        {
            string query = "delete from [TestTable] where TestId =" + testId;
            OleDbConnection Connection = new OleDbConnection(StaticParametr.connectionString);
            OleDbCommand odc = new OleDbCommand(query, Connection);
            Connection.Open();
            odc.ExecuteNonQuery();
            Connection.Close();
          
        }
    }
}
