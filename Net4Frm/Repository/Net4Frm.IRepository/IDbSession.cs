 

namespace Net4Frm.IRepository
{
    public partial interface IDbSession
    {
	
	Ilog_commonRepository log_commonRepository { get; }
	
	Ilog_common_fanRepository log_common_fanRepository { get; }
	
	IN4_DataPrivilege_ofRoleRepository N4_DataPrivilege_ofRoleRepository { get; }
	
	IN4_DataPrivilege_ofUserRepository N4_DataPrivilege_ofUserRepository { get; }
	
	IN4_DataPrivilege_TempleteRepository N4_DataPrivilege_TempleteRepository { get; }
	
	IN4_DepartmentRepository N4_DepartmentRepository { get; }
	
	IN4_DepartmentPrivilegeRepository N4_DepartmentPrivilegeRepository { get; }
	
	IN4_LogRepository N4_LogRepository { get; }
	
	IN4_logToUserLoginoutRepository N4_logToUserLoginoutRepository { get; }
	
	IN4_logToUserOperationRepository N4_logToUserOperationRepository { get; }
	
	IN4_PrivilegeModel_ColumnRepository N4_PrivilegeModel_ColumnRepository { get; }
	
	IN4_PrivilegeModel_ModuleRepository N4_PrivilegeModel_ModuleRepository { get; }
	
	IN4_PrivilegeModel_PrivilegeRepository N4_PrivilegeModel_PrivilegeRepository { get; }
	
	IN4_PrivilegeModelByJSONRepository N4_PrivilegeModelByJSONRepository { get; }
	
	IN4_PrivilegeTagAndFunctionRepository N4_PrivilegeTagAndFunctionRepository { get; }
	
	IN4_RolePrivilegeRepository N4_RolePrivilegeRepository { get; }
	
	IN4_SysDatOriManageModeSetRepository N4_SysDatOriManageModeSetRepository { get; }
	
	IN4_SysDatRoleRepository N4_SysDatRoleRepository { get; }
	
	IN4_SysDatUserRepository N4_SysDatUserRepository { get; }
	
	IN4_UserPrivilegeRepository N4_UserPrivilegeRepository { get; }
	
	IN4_UserRoleAndDepartRepository N4_UserRoleAndDepartRepository { get; }
	
	Itmp_N4_DataPrivilege_ofRoleRepository tmp_N4_DataPrivilege_ofRoleRepository { get; }
	
	Itmp_N4_DataPrivilege_ofUserRepository tmp_N4_DataPrivilege_ofUserRepository { get; }
	
	Itmp_N4_DataPrivilege_TempleteRepository tmp_N4_DataPrivilege_TempleteRepository { get; }
	
	Itmp_N4_DepartmentRepository tmp_N4_DepartmentRepository { get; }
	
	Itmp_N4_DepartmentPrivilegeRepository tmp_N4_DepartmentPrivilegeRepository { get; }
	
	Itmp_N4_LogRepository tmp_N4_LogRepository { get; }
	
	Itmp_N4_logToUserLoginoutRepository tmp_N4_logToUserLoginoutRepository { get; }
	
	Itmp_N4_logToUserOperationRepository tmp_N4_logToUserOperationRepository { get; }
	
	Itmp_N4_PrivilegeModel_ColumnRepository tmp_N4_PrivilegeModel_ColumnRepository { get; }
	
	Itmp_N4_PrivilegeModel_ModuleRepository tmp_N4_PrivilegeModel_ModuleRepository { get; }
	
	Itmp_N4_PrivilegeModel_PrivilegeRepository tmp_N4_PrivilegeModel_PrivilegeRepository { get; }
	
	Itmp_N4_PrivilegeModelByJSONRepository tmp_N4_PrivilegeModelByJSONRepository { get; }
	
	Itmp_N4_PrivilegeTagAndFunctionRepository tmp_N4_PrivilegeTagAndFunctionRepository { get; }
	
	Itmp_N4_RolePrivilegeRepository tmp_N4_RolePrivilegeRepository { get; }
	
	Itmp_N4_SysDatRoleRepository tmp_N4_SysDatRoleRepository { get; }
	
	Itmp_N4_SysDatUserRepository tmp_N4_SysDatUserRepository { get; }
	
	Itmp_N4_UserPrivilegeRepository tmp_N4_UserPrivilegeRepository { get; }
	
	Itmp_N4_UserRoleAndDepartRepository tmp_N4_UserRoleAndDepartRepository { get; }
	
	IWorkCalTemplateRepository WorkCalTemplateRepository { get; }
	}
	
}