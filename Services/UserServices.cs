using Qc_Lab.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using Qc_Lab.Utilities;

namespace Qc_Lab.Services
{
    public class UserServices : IUserServices

    {

        public bool AddUser(string name, string family, string userName, string passWord, string mobile, string email, string address, bool isActive, string imageAddress)
        {
            //string query = "INSERT INTO  [User] (Name,Family,UserName,PassWord,Mobile,Email,Address,IsActive,RegisterDate,ImageAddres) " +
            //    "select '" + name + "','" + family + "','" + userName + "','" + passWord + "','" + mobile + "','" + email + "','" + address + "'," + isActive + "," + registerDate + ",'" + imageAddress + "'";
            string query = "INSERT INTO  [User] (Name,Family,UserName,Mobile,Email,Address,IsActive,ImageAddress) " +
                "select '" + name + "','" + family + "','" + userName + "','" + mobile + "','" + email + "','" + address + "'," + isActive + ",'" + imageAddress + "'";

            OleDbConnection Connection = new OleDbConnection(StaticParametr.connectionString);
            OleDbCommand odc = new OleDbCommand(query, Connection);
            Connection.Open();
            odc.ExecuteNonQuery();
            Connection.Close();
            return true;
        }

        public bool EditUser(int UserId, string name, string family, string userName, string mobile, string email, string address, bool isActiv, string imageAddress)
        {
            string query = "Update [User] set Name='" + name + "' ,Family='" + family + "',UserName='" + userName + "', Mobile='" + mobile + "', Email='" + email + "', Address='" + address + "' ,IsActive=" + isActiv + ",ImageAddress='" + imageAddress + "' where UserId=" + UserId;
            //string query = "Update [User] set Name='" + name + "',Family='" + family + "',UserName='" + userName + "', Mobile='" + mobile + "', Email='" + email + "', Address='" + address + "',IsActive=" + isActiv + "  where UserId=" + UserId;

            OleDbConnection Connection = new OleDbConnection(StaticParametr.connectionString);
            OleDbCommand odc = new OleDbCommand(query, Connection);
            Connection.Open();
            odc.ExecuteNonQuery();
            Connection.Close();
            return true;
        }

        public OleDbDataReader FindUserById(int id)
        {
            string query = "select * from [User] where UserId =" + id + "";
            OleDbConnection Connection = new OleDbConnection(StaticParametr.connectionString);
            OleDbCommand topiccmd = new OleDbCommand(query, Connection);
            Connection.Open();
            OleDbDataReader dr = topiccmd.ExecuteReader();

            return dr;




        }

        public DataTable GetAllRolse()
        {

            string query = "select * from [Role]";
            OleDbConnection connection = new OleDbConnection(StaticParametr.connectionString);
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        public DataTable GetAllPermission()
        {

            string query = "select * from [Permission]";
            OleDbConnection connection = new OleDbConnection(StaticParametr.connectionString);
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public DataTable GetAllUser()
        {
            string query = "select * from [User]";
            OleDbConnection connection = new OleDbConnection(StaticParametr.connectionString);
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public string GetUserName(string userName)
        {
            throw new NotImplementedException();
        }

        public bool LoginCheck(string userName, string passWord)
        {
            string query = "select Count(*) from [User] where UserName ='" + userName.Trim() + "' and password ='" + passWord.Trim() + "'";
            OleDbConnection Connection = new OleDbConnection(StaticParametr.connectionString);
            OleDbCommand topiccmd = new OleDbCommand(query, Connection);
            Connection.Open();
            int numrows = (int)topiccmd.ExecuteScalar();
            Connection.Close();
            return true;
        }

        public DataTable GetAllRolePermission(int roleId = 1)
        {
            string query = "SELECT Permission.PermissionName,Permission.PermissionId,Role_Permission.RP_Id" +
                            " FROM     ((Permission INNER JOIN" +
                            "                  Role_Permission ON Permission.PermissionId = Role_Permission.PermissionId) INNER JOIN" +
                            "                  Role ON Role_Permission.RoleId = Role.RoleId)" +
                            " WHERE(Role.RoleId = "+ roleId + ") order by Permission.PermissionName";
                OleDbConnection connection = new OleDbConnection(StaticParametr.connectionString);
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public OleDbDataReader FindRoleById(int RoleId)
        {
            string query = "select * from [Role] where RoleId =" + RoleId + " order by RoleName";
            OleDbConnection Connection = new OleDbConnection(StaticParametr.connectionString);
            OleDbCommand topiccmd = new OleDbCommand(query, Connection);
            Connection.Open();
            OleDbDataReader dr = topiccmd.ExecuteReader();
            return dr;
        }

        public bool AddRole(string RoleName)
        {
            string query = "INSERT INTO  [Role] (RoleName) " +
           "select '" + RoleName + "'";

            OleDbConnection Connection = new OleDbConnection(StaticParametr.connectionString);
            OleDbCommand odc = new OleDbCommand(query, Connection);
            Connection.Open();
            odc.ExecuteNonQuery();
            Connection.Close();
            return true;
        }

        public bool EditRole(int RoleId,string RoleName)
        {
            string query = "Update [role] set RoleName='" + RoleName + "'  where RoleId=" + RoleId;
            //string query = "Update [User] set Name='" + name + "',Family='" + family + "',UserName='" + userName + "', Mobile='" + mobile + "', Email='" + email + "', Address='" + address + "',IsActive=" + isActiv + "  where UserId=" + UserId;

            OleDbConnection Connection = new OleDbConnection(StaticParametr.connectionString);
            OleDbCommand odc = new OleDbCommand(query, Connection);
            Connection.Open();
            odc.ExecuteNonQuery();
            Connection.Close();
            return true;
        }

        public void DeleteRole_Permission(int RoleId, int permissionId)
        {
            string query = "Delete From [Role_Permission]   where RoleId=" + RoleId + " and PermissionId="+permissionId;
            //string query = "Update [User] set Name='" + name + "',Family='" + family + "',UserName='" + userName + "', Mobile='" + mobile + "', Email='" + email + "', Address='" + address + "',IsActive=" + isActiv + "  where UserId=" + UserId;

            OleDbConnection Connection = new OleDbConnection(StaticParametr.connectionString);
            OleDbCommand odc = new OleDbCommand(query, Connection);
            Connection.Open();
            odc.ExecuteNonQuery();
            Connection.Close();

        }
        public void DeleteRole(int RoleId)
        {
            DeleteRole_All_Permission(RoleId);
            string query = "Delete From [role]   where RoleId=" + RoleId;
            //string query = "Update [User] set Name='" + name + "',Family='" + family + "',UserName='" + userName + "', Mobile='" + mobile + "', Email='" + email + "', Address='" + address + "',IsActive=" + isActiv + "  where UserId=" + UserId;
            OleDbConnection Connection = new OleDbConnection(StaticParametr.connectionString);
            OleDbCommand odc = new OleDbCommand(query, Connection);
            Connection.Open();
            odc.ExecuteNonQuery();
            Connection.Close();
            
        }

        public void AddRole_permission(int roleId, int permissionId)
        {
            //DeleteRole_Permission(roleId);
            string query = "INSERT INTO  [Role_Permission] (RoleId,PermissionId) " +
                         "select " + roleId + " , "+permissionId+"";

            OleDbConnection Connection = new OleDbConnection(StaticParametr.connectionString);
            OleDbCommand odc = new OleDbCommand(query, Connection);
            Connection.Open();
            odc.ExecuteNonQuery();
            Connection.Close();
            
        }

        public DataTable GetAllUserRoles(int userId)
        {
            string query = "SELECT UserRole.UR_Id,Role.RoleName" +
                            " FROM     ((Role INNER JOIN" +
                            "                  UserRole ON Role.RoleId = UserRole.RoleId) INNER JOIN" +
                            "                  [User] ON UserRole.Userid = [User].Userid)" +
                            " WHERE([User].Userid = " + userId + ") order by Role.RoleName";

            OleDbConnection connection = new OleDbConnection(StaticParametr.connectionString);
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public void AddUserRole(int userId, int roleId)
        {
           
            string query = "INSERT INTO  [UserRole] (UserId,RoleId) " +
                         "select " + userId + " , " + roleId + "";

            OleDbConnection Connection = new OleDbConnection(StaticParametr.connectionString);
            OleDbCommand odc = new OleDbCommand(query, Connection);
            Connection.Open();
            odc.ExecuteNonQuery();
            Connection.Close();
        }

        public void DeleteUserRole(int userId)
        {
           
            string query = "Delete From [UserRole]   where UserId=" + userId;
            //string query = "Update [User] set Name='" + name + "',Family='" + family + "',UserName='" + userName + "', Mobile='" + mobile + "', Email='" + email + "', Address='" + address + "',IsActive=" + isActiv + "  where UserId=" + UserId;
            OleDbConnection Connection = new OleDbConnection(StaticParametr.connectionString);
            OleDbCommand odc = new OleDbCommand(query, Connection);
            Connection.Open();
            odc.ExecuteNonQuery();
            Connection.Close();
        }

        public void DeleteUserRoleByRoleId(int UR_Id)
        {
            string query = "Delete From [UserRole]   where UR_Id=" + UR_Id;
            //string query = "Update [User] set Name='" + name + "',Family='" + family + "',UserName='" + userName + "', Mobile='" + mobile + "', Email='" + email + "', Address='" + address + "',IsActive=" + isActiv + "  where UserId=" + UserId;
            OleDbConnection Connection = new OleDbConnection(StaticParametr.connectionString);
            OleDbCommand odc = new OleDbCommand(query, Connection);
            Connection.Open();
            odc.ExecuteNonQuery();
            Connection.Close();
        }

        public OleDbDataReader GetUserId(string userName, string passWord)
        {
            string query = "select UserId from [User] where UserName ='" + userName.Trim() + "' and password ='" + passWord.Trim() + "'";
            OleDbConnection Connection = new OleDbConnection(StaticParametr.connectionString);
            OleDbCommand topiccmd = new OleDbCommand(query, Connection);
            Connection.Open();
            OleDbDataReader dr = topiccmd.ExecuteReader();
            return dr;
        }

        public OleDbDataReader GetUserByUserName(string userName)
        {
            string query = "select UserId  from [User] where UserName ='" + userName.Trim() + "' ";      
            OleDbConnection Connection = new OleDbConnection(StaticParametr.connectionString);
            OleDbCommand topiccmd = new OleDbCommand(query, Connection);
            Connection.Open();
            OleDbDataReader dr = topiccmd.ExecuteReader();
            return dr;
        }

        public OleDbDataReader GetAccess(int userId, string permissionLatinName)
        {
            string query = "SELECT Permission.PermissionName" +
                            " FROM     ((Permission INNER JOIN" +
                            "                  Role_Permission ON Permission.PermissionId = Role_Permission.PermissionId) INNER JOIN" +
                            "                  UserRole ON Role_Permission.RoleId = UserRole.RoleId)" +
                            " WHERE(UserRole.UserId = " + userId + " and Permission.PermissionLatinName='"+ permissionLatinName + "' ) order by Permission.PermissionName";
            OleDbConnection Connection = new OleDbConnection(StaticParametr.connectionString);
            OleDbCommand topiccmd = new OleDbCommand(query, Connection);
            Connection.Open();
            OleDbDataReader dr = topiccmd.ExecuteReader();
            return dr;
        }

        public void DeleteRole_All_Permission(int RoleId)
        {
            string query = "Delete From [Role_Permission]   where RoleId=" + RoleId ;
            //string query = "Update [User] set Name='" + name + "',Family='" + family + "',UserName='" + userName + "', Mobile='" + mobile + "', Email='" + email + "', Address='" + address + "',IsActive=" + isActiv + "  where UserId=" + UserId;

            OleDbConnection Connection = new OleDbConnection(StaticParametr.connectionString);
            OleDbCommand odc = new OleDbCommand(query, Connection);
            Connection.Open();
            odc.ExecuteNonQuery();
            Connection.Close();
        }

        public void DeleteRolePermissionByRolePermissionId(int RP_Id)
        {
            string query = "Delete From [Role_Permission]   where RP_Id=" + RP_Id;
            //string query = "Update [User] set Name='" + name + "',Family='" + family + "',UserName='" + userName + "', Mobile='" + mobile + "', Email='" + email + "', Address='" + address + "',IsActive=" + isActiv + "  where UserId=" + UserId;

            OleDbConnection Connection = new OleDbConnection(StaticParametr.connectionString);
            OleDbCommand odc = new OleDbCommand(query, Connection);
            Connection.Open();
            odc.ExecuteNonQuery();
            Connection.Close();
        }
    }

}

