namespace CafeShop.BUS;

public class RoleBUS
{
    private static RoleBUS _instance;
    public static RoleBUS Instance
    {
        get
        {
            _instance ??= new RoleBUS();
            return _instance;
        }
        private set { _instance = value; }
    }
    public List<RoleDTO> GetRoles() => RoleDAO.Instance.GetRoles();

    public List<RoleDTO> GetRole(string roleName) => RoleDAO.Instance.GetRole(roleName);

    public bool InsertRole(RoleDTO roleDTO) => RoleDAO.Instance.InsertRole(roleDTO);

    public bool UpdateRole(RoleDTO roleDTO) => RoleDAO.Instance.UpdateRole(roleDTO);

    public bool DeleteRole(int roleID) => RoleDAO.Instance.DeleteRole(roleID);




}
