using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qc_Lab.Services.Interfaces
{
  public  interface IUserServices
    {
        #region Users
        bool LoginCheck(string userName, string passWord);
        string GetUserName(string userName);
        bool AddUser(string name, string family, string userName, string passWord, string mobile, string email, string address, bool isActive, string imageAddress);
        bool EditUser(int UserId, string name, string family, string userName, string mobile, string email, string address, bool isActiv, string imageAddress);
        DataTable GetAllUser();
        OleDbDataReader FindUserById(int id);
        DataTable GetAllUserRoles(int userId);
        OleDbDataReader GetUserId(string userName, string passWord);
        OleDbDataReader GetUserByUserName(string userName);
        #endregion

        #region Rolse
        DataTable GetAllRolse();
        DataTable GetAllPermission();
        DataTable GetAllRolePermission(int roleId);
        OleDbDataReader FindRoleById(int RoleId);
        bool AddRole(string RoleName);
        bool EditRole(int RoleId,string RoleName);
        void DeleteRole(int RoleId);
        void DeleteRole_Permission(int RoleId, int permissionId);
        void DeleteRole_All_Permission(int RoleId);
        void AddRole_permission(int roleId, int permissionId);
        void AddUserRole(int userId, int roleId);
        void DeleteUserRole(int userId);
        void DeleteUserRoleByRoleId(int UR_Id);
       void DeleteRolePermissionByRolePermissionId(int RP_Id);
        #endregion

        #region access
        OleDbDataReader GetAccess(int userId, string permissionLatinName);
        #endregion

    }
}
