using System.Text.Json.Serialization;
using System.Text.Json;

namespace CafeShop.DAO;

internal class RoleDAO
{
    private static readonly JsonSerializerOptions _options = new() { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull };
    private static RoleDAO _instance;
    public static RoleDAO Instance
    {
        get
        {
            _instance ??= new RoleDAO();
            return _instance;
        }
        private set { _instance = value; }
    }
    public List<RoleDTO> GetRoles() => DataProvider.Instance.ExecuteProcedureGetList<RoleDTO>("SP_GetRoles");

    public List<RoleDTO> GetRole(string roleName)
    {
        DataProvider.Instance.AddInputParameter("RoleName", roleName);
        List<RoleDTO> role = DataProvider.Instance.ExecuteProcedureGetList<RoleDTO>("SP_RoleSearch");
        return role;
    }
    
    public bool InsertRole(RoleDTO role)
    {
        try
        {
            DataProvider.Instance.AddInputParameter("RoleName", role.RoleName);
            DataProvider.Instance.AddInputParameter("Note", role.Note);
            DataProvider.Instance.AddInputParameter("UserID", Core.AppContext.UserID);
            DataProvider.Instance.AddInputParameter("Paramerters", JsonSerializer.Serialize(role, _options));
            DataProvider.Instance.ExecuteProcedure<EmptyData>("SP_InsertRole");
            return true;
        }
        catch
        {
            return false;
        }
    }
    public bool UpdateRole(RoleDTO role)
    {
        try
        {
            DataProvider.Instance.AddInputParameter("RoleID", role.RoleID);
            DataProvider.Instance.AddInputParameter("RoleName", role.RoleName);
            DataProvider.Instance.AddInputParameter("Note", role.Note);
            DataProvider.Instance.AddInputParameter("UserID", Core.AppContext.UserID);
            DataProvider.Instance.AddInputParameter("Paramerters", JsonSerializer.Serialize(role, _options));
            DataProvider.Instance.ExecuteProcedure<EmptyData>("SP_UpdateRole");
            return true;
        }
        catch
        {

            return false;
        }
    }
    public bool DeleteRole(int roleID)
    {
        try
        {
            DataProvider.Instance.AddInputParameter("RoleID", roleID);
            DataProvider.Instance.AddInputParameter("UserID", Core.AppContext.UserID);
            DataProvider.Instance.AddInputParameter("Paramerters", JsonSerializer.Serialize(new { RoleID = roleID }, _options));
            DataProvider.Instance.ExecuteProcedure<EmptyData>("SP_DeleteRole");
            return true;
        }
        catch
        {
            return false;
        }
    }


}
