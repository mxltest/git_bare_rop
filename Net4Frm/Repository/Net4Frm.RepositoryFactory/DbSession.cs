 
using Net4Frm.IRepository;
using Net4Frm.Repository;
namespace Net4Frm.RepositoryFactory
{
    public partial class DbSession : IDbSession
    {
	
		private Ilog_commonRepository _log_commonRepository;
        public Ilog_commonRepository log_commonRepository
        {
            get
            {
                if (null == _log_commonRepository)
                {
                    _log_commonRepository = new log_commonRepository(this.unitOfWork);
                }
                return _log_commonRepository;
            }
        }
	
		private Ilog_common_fanRepository _log_common_fanRepository;
        public Ilog_common_fanRepository log_common_fanRepository
        {
            get
            {
                if (null == _log_common_fanRepository)
                {
                    _log_common_fanRepository = new log_common_fanRepository(this.unitOfWork);
                }
                return _log_common_fanRepository;
            }
        }
	
		private IN4_DataPrivilege_ofRoleRepository _N4_DataPrivilege_ofRoleRepository;
        public IN4_DataPrivilege_ofRoleRepository N4_DataPrivilege_ofRoleRepository
        {
            get
            {
                if (null == _N4_DataPrivilege_ofRoleRepository)
                {
                    _N4_DataPrivilege_ofRoleRepository = new N4_DataPrivilege_ofRoleRepository(this.unitOfWork);
                }
                return _N4_DataPrivilege_ofRoleRepository;
            }
        }
	
		private IN4_DataPrivilege_ofUserRepository _N4_DataPrivilege_ofUserRepository;
        public IN4_DataPrivilege_ofUserRepository N4_DataPrivilege_ofUserRepository
        {
            get
            {
                if (null == _N4_DataPrivilege_ofUserRepository)
                {
                    _N4_DataPrivilege_ofUserRepository = new N4_DataPrivilege_ofUserRepository(this.unitOfWork);
                }
                return _N4_DataPrivilege_ofUserRepository;
            }
        }
	
		private IN4_DataPrivilege_TempleteRepository _N4_DataPrivilege_TempleteRepository;
        public IN4_DataPrivilege_TempleteRepository N4_DataPrivilege_TempleteRepository
        {
            get
            {
                if (null == _N4_DataPrivilege_TempleteRepository)
                {
                    _N4_DataPrivilege_TempleteRepository = new N4_DataPrivilege_TempleteRepository(this.unitOfWork);
                }
                return _N4_DataPrivilege_TempleteRepository;
            }
        }
	
		private IN4_DepartmentRepository _N4_DepartmentRepository;
        public IN4_DepartmentRepository N4_DepartmentRepository
        {
            get
            {
                if (null == _N4_DepartmentRepository)
                {
                    _N4_DepartmentRepository = new N4_DepartmentRepository(this.unitOfWork);
                }
                return _N4_DepartmentRepository;
            }
        }
	
		private IN4_DepartmentPrivilegeRepository _N4_DepartmentPrivilegeRepository;
        public IN4_DepartmentPrivilegeRepository N4_DepartmentPrivilegeRepository
        {
            get
            {
                if (null == _N4_DepartmentPrivilegeRepository)
                {
                    _N4_DepartmentPrivilegeRepository = new N4_DepartmentPrivilegeRepository(this.unitOfWork);
                }
                return _N4_DepartmentPrivilegeRepository;
            }
        }
	
		private IN4_LogRepository _N4_LogRepository;
        public IN4_LogRepository N4_LogRepository
        {
            get
            {
                if (null == _N4_LogRepository)
                {
                    _N4_LogRepository = new N4_LogRepository(this.unitOfWork);
                }
                return _N4_LogRepository;
            }
        }
	
		private IN4_logToUserLoginoutRepository _N4_logToUserLoginoutRepository;
        public IN4_logToUserLoginoutRepository N4_logToUserLoginoutRepository
        {
            get
            {
                if (null == _N4_logToUserLoginoutRepository)
                {
                    _N4_logToUserLoginoutRepository = new N4_logToUserLoginoutRepository(this.unitOfWork);
                }
                return _N4_logToUserLoginoutRepository;
            }
        }
	
		private IN4_logToUserOperationRepository _N4_logToUserOperationRepository;
        public IN4_logToUserOperationRepository N4_logToUserOperationRepository
        {
            get
            {
                if (null == _N4_logToUserOperationRepository)
                {
                    _N4_logToUserOperationRepository = new N4_logToUserOperationRepository(this.unitOfWork);
                }
                return _N4_logToUserOperationRepository;
            }
        }
	
		private IN4_PrivilegeModel_ColumnRepository _N4_PrivilegeModel_ColumnRepository;
        public IN4_PrivilegeModel_ColumnRepository N4_PrivilegeModel_ColumnRepository
        {
            get
            {
                if (null == _N4_PrivilegeModel_ColumnRepository)
                {
                    _N4_PrivilegeModel_ColumnRepository = new N4_PrivilegeModel_ColumnRepository(this.unitOfWork);
                }
                return _N4_PrivilegeModel_ColumnRepository;
            }
        }
	
		private IN4_PrivilegeModel_ModuleRepository _N4_PrivilegeModel_ModuleRepository;
        public IN4_PrivilegeModel_ModuleRepository N4_PrivilegeModel_ModuleRepository
        {
            get
            {
                if (null == _N4_PrivilegeModel_ModuleRepository)
                {
                    _N4_PrivilegeModel_ModuleRepository = new N4_PrivilegeModel_ModuleRepository(this.unitOfWork);
                }
                return _N4_PrivilegeModel_ModuleRepository;
            }
        }
	
		private IN4_PrivilegeModel_PrivilegeRepository _N4_PrivilegeModel_PrivilegeRepository;
        public IN4_PrivilegeModel_PrivilegeRepository N4_PrivilegeModel_PrivilegeRepository
        {
            get
            {
                if (null == _N4_PrivilegeModel_PrivilegeRepository)
                {
                    _N4_PrivilegeModel_PrivilegeRepository = new N4_PrivilegeModel_PrivilegeRepository(this.unitOfWork);
                }
                return _N4_PrivilegeModel_PrivilegeRepository;
            }
        }
	
		private IN4_PrivilegeModelByJSONRepository _N4_PrivilegeModelByJSONRepository;
        public IN4_PrivilegeModelByJSONRepository N4_PrivilegeModelByJSONRepository
        {
            get
            {
                if (null == _N4_PrivilegeModelByJSONRepository)
                {
                    _N4_PrivilegeModelByJSONRepository = new N4_PrivilegeModelByJSONRepository(this.unitOfWork);
                }
                return _N4_PrivilegeModelByJSONRepository;
            }
        }
	
		private IN4_PrivilegeTagAndFunctionRepository _N4_PrivilegeTagAndFunctionRepository;
        public IN4_PrivilegeTagAndFunctionRepository N4_PrivilegeTagAndFunctionRepository
        {
            get
            {
                if (null == _N4_PrivilegeTagAndFunctionRepository)
                {
                    _N4_PrivilegeTagAndFunctionRepository = new N4_PrivilegeTagAndFunctionRepository(this.unitOfWork);
                }
                return _N4_PrivilegeTagAndFunctionRepository;
            }
        }
	
		private IN4_RolePrivilegeRepository _N4_RolePrivilegeRepository;
        public IN4_RolePrivilegeRepository N4_RolePrivilegeRepository
        {
            get
            {
                if (null == _N4_RolePrivilegeRepository)
                {
                    _N4_RolePrivilegeRepository = new N4_RolePrivilegeRepository(this.unitOfWork);
                }
                return _N4_RolePrivilegeRepository;
            }
        }
	
		private IN4_SysDatOriManageModeSetRepository _N4_SysDatOriManageModeSetRepository;
        public IN4_SysDatOriManageModeSetRepository N4_SysDatOriManageModeSetRepository
        {
            get
            {
                if (null == _N4_SysDatOriManageModeSetRepository)
                {
                    _N4_SysDatOriManageModeSetRepository = new N4_SysDatOriManageModeSetRepository(this.unitOfWork);
                }
                return _N4_SysDatOriManageModeSetRepository;
            }
        }
	
		private IN4_SysDatRoleRepository _N4_SysDatRoleRepository;
        public IN4_SysDatRoleRepository N4_SysDatRoleRepository
        {
            get
            {
                if (null == _N4_SysDatRoleRepository)
                {
                    _N4_SysDatRoleRepository = new N4_SysDatRoleRepository(this.unitOfWork);
                }
                return _N4_SysDatRoleRepository;
            }
        }
	
		private IN4_SysDatUserRepository _N4_SysDatUserRepository;
        public IN4_SysDatUserRepository N4_SysDatUserRepository
        {
            get
            {
                if (null == _N4_SysDatUserRepository)
                {
                    _N4_SysDatUserRepository = new N4_SysDatUserRepository(this.unitOfWork);
                }
                return _N4_SysDatUserRepository;
            }
        }
	
		private IN4_UserPrivilegeRepository _N4_UserPrivilegeRepository;
        public IN4_UserPrivilegeRepository N4_UserPrivilegeRepository
        {
            get
            {
                if (null == _N4_UserPrivilegeRepository)
                {
                    _N4_UserPrivilegeRepository = new N4_UserPrivilegeRepository(this.unitOfWork);
                }
                return _N4_UserPrivilegeRepository;
            }
        }
	
		private IN4_UserRoleAndDepartRepository _N4_UserRoleAndDepartRepository;
        public IN4_UserRoleAndDepartRepository N4_UserRoleAndDepartRepository
        {
            get
            {
                if (null == _N4_UserRoleAndDepartRepository)
                {
                    _N4_UserRoleAndDepartRepository = new N4_UserRoleAndDepartRepository(this.unitOfWork);
                }
                return _N4_UserRoleAndDepartRepository;
            }
        }
	
		private Itmp_N4_DataPrivilege_ofRoleRepository _tmp_N4_DataPrivilege_ofRoleRepository;
        public Itmp_N4_DataPrivilege_ofRoleRepository tmp_N4_DataPrivilege_ofRoleRepository
        {
            get
            {
                if (null == _tmp_N4_DataPrivilege_ofRoleRepository)
                {
                    _tmp_N4_DataPrivilege_ofRoleRepository = new tmp_N4_DataPrivilege_ofRoleRepository(this.unitOfWork);
                }
                return _tmp_N4_DataPrivilege_ofRoleRepository;
            }
        }
	
		private Itmp_N4_DataPrivilege_ofUserRepository _tmp_N4_DataPrivilege_ofUserRepository;
        public Itmp_N4_DataPrivilege_ofUserRepository tmp_N4_DataPrivilege_ofUserRepository
        {
            get
            {
                if (null == _tmp_N4_DataPrivilege_ofUserRepository)
                {
                    _tmp_N4_DataPrivilege_ofUserRepository = new tmp_N4_DataPrivilege_ofUserRepository(this.unitOfWork);
                }
                return _tmp_N4_DataPrivilege_ofUserRepository;
            }
        }
	
		private Itmp_N4_DataPrivilege_TempleteRepository _tmp_N4_DataPrivilege_TempleteRepository;
        public Itmp_N4_DataPrivilege_TempleteRepository tmp_N4_DataPrivilege_TempleteRepository
        {
            get
            {
                if (null == _tmp_N4_DataPrivilege_TempleteRepository)
                {
                    _tmp_N4_DataPrivilege_TempleteRepository = new tmp_N4_DataPrivilege_TempleteRepository(this.unitOfWork);
                }
                return _tmp_N4_DataPrivilege_TempleteRepository;
            }
        }
	
		private Itmp_N4_DepartmentRepository _tmp_N4_DepartmentRepository;
        public Itmp_N4_DepartmentRepository tmp_N4_DepartmentRepository
        {
            get
            {
                if (null == _tmp_N4_DepartmentRepository)
                {
                    _tmp_N4_DepartmentRepository = new tmp_N4_DepartmentRepository(this.unitOfWork);
                }
                return _tmp_N4_DepartmentRepository;
            }
        }
	
		private Itmp_N4_DepartmentPrivilegeRepository _tmp_N4_DepartmentPrivilegeRepository;
        public Itmp_N4_DepartmentPrivilegeRepository tmp_N4_DepartmentPrivilegeRepository
        {
            get
            {
                if (null == _tmp_N4_DepartmentPrivilegeRepository)
                {
                    _tmp_N4_DepartmentPrivilegeRepository = new tmp_N4_DepartmentPrivilegeRepository(this.unitOfWork);
                }
                return _tmp_N4_DepartmentPrivilegeRepository;
            }
        }
	
		private Itmp_N4_LogRepository _tmp_N4_LogRepository;
        public Itmp_N4_LogRepository tmp_N4_LogRepository
        {
            get
            {
                if (null == _tmp_N4_LogRepository)
                {
                    _tmp_N4_LogRepository = new tmp_N4_LogRepository(this.unitOfWork);
                }
                return _tmp_N4_LogRepository;
            }
        }
	
		private Itmp_N4_logToUserLoginoutRepository _tmp_N4_logToUserLoginoutRepository;
        public Itmp_N4_logToUserLoginoutRepository tmp_N4_logToUserLoginoutRepository
        {
            get
            {
                if (null == _tmp_N4_logToUserLoginoutRepository)
                {
                    _tmp_N4_logToUserLoginoutRepository = new tmp_N4_logToUserLoginoutRepository(this.unitOfWork);
                }
                return _tmp_N4_logToUserLoginoutRepository;
            }
        }
	
		private Itmp_N4_logToUserOperationRepository _tmp_N4_logToUserOperationRepository;
        public Itmp_N4_logToUserOperationRepository tmp_N4_logToUserOperationRepository
        {
            get
            {
                if (null == _tmp_N4_logToUserOperationRepository)
                {
                    _tmp_N4_logToUserOperationRepository = new tmp_N4_logToUserOperationRepository(this.unitOfWork);
                }
                return _tmp_N4_logToUserOperationRepository;
            }
        }
	
		private Itmp_N4_PrivilegeModel_ColumnRepository _tmp_N4_PrivilegeModel_ColumnRepository;
        public Itmp_N4_PrivilegeModel_ColumnRepository tmp_N4_PrivilegeModel_ColumnRepository
        {
            get
            {
                if (null == _tmp_N4_PrivilegeModel_ColumnRepository)
                {
                    _tmp_N4_PrivilegeModel_ColumnRepository = new tmp_N4_PrivilegeModel_ColumnRepository(this.unitOfWork);
                }
                return _tmp_N4_PrivilegeModel_ColumnRepository;
            }
        }
	
		private Itmp_N4_PrivilegeModel_ModuleRepository _tmp_N4_PrivilegeModel_ModuleRepository;
        public Itmp_N4_PrivilegeModel_ModuleRepository tmp_N4_PrivilegeModel_ModuleRepository
        {
            get
            {
                if (null == _tmp_N4_PrivilegeModel_ModuleRepository)
                {
                    _tmp_N4_PrivilegeModel_ModuleRepository = new tmp_N4_PrivilegeModel_ModuleRepository(this.unitOfWork);
                }
                return _tmp_N4_PrivilegeModel_ModuleRepository;
            }
        }
	
		private Itmp_N4_PrivilegeModel_PrivilegeRepository _tmp_N4_PrivilegeModel_PrivilegeRepository;
        public Itmp_N4_PrivilegeModel_PrivilegeRepository tmp_N4_PrivilegeModel_PrivilegeRepository
        {
            get
            {
                if (null == _tmp_N4_PrivilegeModel_PrivilegeRepository)
                {
                    _tmp_N4_PrivilegeModel_PrivilegeRepository = new tmp_N4_PrivilegeModel_PrivilegeRepository(this.unitOfWork);
                }
                return _tmp_N4_PrivilegeModel_PrivilegeRepository;
            }
        }
	
		private Itmp_N4_PrivilegeModelByJSONRepository _tmp_N4_PrivilegeModelByJSONRepository;
        public Itmp_N4_PrivilegeModelByJSONRepository tmp_N4_PrivilegeModelByJSONRepository
        {
            get
            {
                if (null == _tmp_N4_PrivilegeModelByJSONRepository)
                {
                    _tmp_N4_PrivilegeModelByJSONRepository = new tmp_N4_PrivilegeModelByJSONRepository(this.unitOfWork);
                }
                return _tmp_N4_PrivilegeModelByJSONRepository;
            }
        }
	
		private Itmp_N4_PrivilegeTagAndFunctionRepository _tmp_N4_PrivilegeTagAndFunctionRepository;
        public Itmp_N4_PrivilegeTagAndFunctionRepository tmp_N4_PrivilegeTagAndFunctionRepository
        {
            get
            {
                if (null == _tmp_N4_PrivilegeTagAndFunctionRepository)
                {
                    _tmp_N4_PrivilegeTagAndFunctionRepository = new tmp_N4_PrivilegeTagAndFunctionRepository(this.unitOfWork);
                }
                return _tmp_N4_PrivilegeTagAndFunctionRepository;
            }
        }
	
		private Itmp_N4_RolePrivilegeRepository _tmp_N4_RolePrivilegeRepository;
        public Itmp_N4_RolePrivilegeRepository tmp_N4_RolePrivilegeRepository
        {
            get
            {
                if (null == _tmp_N4_RolePrivilegeRepository)
                {
                    _tmp_N4_RolePrivilegeRepository = new tmp_N4_RolePrivilegeRepository(this.unitOfWork);
                }
                return _tmp_N4_RolePrivilegeRepository;
            }
        }
	
		private Itmp_N4_SysDatRoleRepository _tmp_N4_SysDatRoleRepository;
        public Itmp_N4_SysDatRoleRepository tmp_N4_SysDatRoleRepository
        {
            get
            {
                if (null == _tmp_N4_SysDatRoleRepository)
                {
                    _tmp_N4_SysDatRoleRepository = new tmp_N4_SysDatRoleRepository(this.unitOfWork);
                }
                return _tmp_N4_SysDatRoleRepository;
            }
        }
	
		private Itmp_N4_SysDatUserRepository _tmp_N4_SysDatUserRepository;
        public Itmp_N4_SysDatUserRepository tmp_N4_SysDatUserRepository
        {
            get
            {
                if (null == _tmp_N4_SysDatUserRepository)
                {
                    _tmp_N4_SysDatUserRepository = new tmp_N4_SysDatUserRepository(this.unitOfWork);
                }
                return _tmp_N4_SysDatUserRepository;
            }
        }
	
		private Itmp_N4_UserPrivilegeRepository _tmp_N4_UserPrivilegeRepository;
        public Itmp_N4_UserPrivilegeRepository tmp_N4_UserPrivilegeRepository
        {
            get
            {
                if (null == _tmp_N4_UserPrivilegeRepository)
                {
                    _tmp_N4_UserPrivilegeRepository = new tmp_N4_UserPrivilegeRepository(this.unitOfWork);
                }
                return _tmp_N4_UserPrivilegeRepository;
            }
        }
	
		private Itmp_N4_UserRoleAndDepartRepository _tmp_N4_UserRoleAndDepartRepository;
        public Itmp_N4_UserRoleAndDepartRepository tmp_N4_UserRoleAndDepartRepository
        {
            get
            {
                if (null == _tmp_N4_UserRoleAndDepartRepository)
                {
                    _tmp_N4_UserRoleAndDepartRepository = new tmp_N4_UserRoleAndDepartRepository(this.unitOfWork);
                }
                return _tmp_N4_UserRoleAndDepartRepository;
            }
        }
	
		private IWorkCalTemplateRepository _WorkCalTemplateRepository;
        public IWorkCalTemplateRepository WorkCalTemplateRepository
        {
            get
            {
                if (null == _WorkCalTemplateRepository)
                {
                    _WorkCalTemplateRepository = new WorkCalTemplateRepository(this.unitOfWork);
                }
                return _WorkCalTemplateRepository;
            }
        }
	}
}