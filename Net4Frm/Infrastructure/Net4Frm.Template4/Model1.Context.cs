﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Net4Frm.Template4
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Net4FrmEntities : DbContext
    {
        public Net4FrmEntities()
            : base("name=Net4FrmEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<log_common> log_common { get; set; }
        public DbSet<log_common_fan> log_common_fan { get; set; }
        public DbSet<N4_DataPrivilege_ofRole> N4_DataPrivilege_ofRole { get; set; }
        public DbSet<N4_DataPrivilege_ofUser> N4_DataPrivilege_ofUser { get; set; }
        public DbSet<N4_DataPrivilege_Templete> N4_DataPrivilege_Templete { get; set; }
        public DbSet<N4_Department> N4_Department { get; set; }
        public DbSet<N4_DepartmentPrivilege> N4_DepartmentPrivilege { get; set; }
        public DbSet<N4_Log> N4_Log { get; set; }
        public DbSet<N4_logToUserLoginout> N4_logToUserLoginout { get; set; }
        public DbSet<N4_logToUserOperation> N4_logToUserOperation { get; set; }
        public DbSet<N4_PrivilegeModel_Column> N4_PrivilegeModel_Column { get; set; }
        public DbSet<N4_PrivilegeModel_Module> N4_PrivilegeModel_Module { get; set; }
        public DbSet<N4_PrivilegeModel_Privilege> N4_PrivilegeModel_Privilege { get; set; }
        public DbSet<N4_PrivilegeModelByJSON> N4_PrivilegeModelByJSON { get; set; }
        public DbSet<N4_PrivilegeTagAndFunction> N4_PrivilegeTagAndFunction { get; set; }
        public DbSet<N4_RolePrivilege> N4_RolePrivilege { get; set; }
        public DbSet<N4_SysDatOriManageModeSet> N4_SysDatOriManageModeSet { get; set; }
        public DbSet<N4_SysDatRole> N4_SysDatRole { get; set; }
        public DbSet<N4_SysDatUser> N4_SysDatUser { get; set; }
        public DbSet<N4_UserPrivilege> N4_UserPrivilege { get; set; }
        public DbSet<N4_UserRoleAndDepart> N4_UserRoleAndDepart { get; set; }
        public DbSet<tmp_N4_DataPrivilege_ofRole> tmp_N4_DataPrivilege_ofRole { get; set; }
        public DbSet<tmp_N4_DataPrivilege_ofUser> tmp_N4_DataPrivilege_ofUser { get; set; }
        public DbSet<tmp_N4_DataPrivilege_Templete> tmp_N4_DataPrivilege_Templete { get; set; }
        public DbSet<tmp_N4_Department> tmp_N4_Department { get; set; }
        public DbSet<tmp_N4_DepartmentPrivilege> tmp_N4_DepartmentPrivilege { get; set; }
        public DbSet<tmp_N4_Log> tmp_N4_Log { get; set; }
        public DbSet<tmp_N4_logToUserLoginout> tmp_N4_logToUserLoginout { get; set; }
        public DbSet<tmp_N4_logToUserOperation> tmp_N4_logToUserOperation { get; set; }
        public DbSet<tmp_N4_PrivilegeModel_Column> tmp_N4_PrivilegeModel_Column { get; set; }
        public DbSet<tmp_N4_PrivilegeModel_Module> tmp_N4_PrivilegeModel_Module { get; set; }
        public DbSet<tmp_N4_PrivilegeModel_Privilege> tmp_N4_PrivilegeModel_Privilege { get; set; }
        public DbSet<tmp_N4_PrivilegeModelByJSON> tmp_N4_PrivilegeModelByJSON { get; set; }
        public DbSet<tmp_N4_PrivilegeTagAndFunction> tmp_N4_PrivilegeTagAndFunction { get; set; }
        public DbSet<tmp_N4_RolePrivilege> tmp_N4_RolePrivilege { get; set; }
        public DbSet<tmp_N4_SysDatRole> tmp_N4_SysDatRole { get; set; }
        public DbSet<tmp_N4_SysDatUser> tmp_N4_SysDatUser { get; set; }
        public DbSet<tmp_N4_UserPrivilege> tmp_N4_UserPrivilege { get; set; }
        public DbSet<tmp_N4_UserRoleAndDepart> tmp_N4_UserRoleAndDepart { get; set; }
        public DbSet<WorkCalTemplate> WorkCalTemplates { get; set; }
    }
}
