namespace CompanyCode.ApiTemplate.Repository.Ingres.SqlQueries
{
    public class AuthQueries
    {
        public const string GetUserLogin =
            @"SELECT
                    TRIM(o.operator_id)     AS OperatorId,
                    o.group_id              AS GroupId,
                    op.is_enabled           AS IsEnabled,
                    TRIM(o.operator_name)   AS OperatorName,
                    TRIM(o.email_addr)      AS EmailAddress,
                    TRIM(o.mobile_no)       AS MobileNumber,
                    op.password_hash        AS PasswordHash,
                    op.password_salt        AS PasswordSalt,
                    op.bad_login_count      AS BadLoginCount,
                    op.lock_ind             AS IsLocked,
                    op.last_login_date      AS LastLoginDate,
                    ar.role_id              AS roleId,
                    TRIM(ar.description)    AS Role
                FROM operator o                    
                    JOIN operator_password op ON op.operator_id = o.operator_id
                    JOIN appln_role ar on op.bus_unit_code = ar.bus_unit_type AND ar.role_id = op.role_id   
                WHERE  
                    op.bus_unit_code = 'FTR'
                    AND op.is_enabled = 1
                    AND op.operator_id = :operatorId";

        public const string GetUserRoles =
            @"SELECT TRIM(ar.description)    AS Role
                FROM operator o                    
                    JOIN operator_password op ON op.operator_id = o.operator_id
                    JOIN appln_role ar on op.bus_unit_code = ar.bus_unit_type AND ar.role_id = op.role_id   
                WHERE 
                    op.bus_unit_code = 'FTR'
                    AND oP.is_enabled = 1
                    AND oP.operator_id = :operatorId
                    AND ar.description in (:roles)";
    }
}