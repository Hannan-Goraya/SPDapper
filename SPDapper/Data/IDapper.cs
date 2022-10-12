using Dapper;

namespace SPDapper.Data
{
    public interface IDapper
    {
        T ExecuteReturnScalar<T>(string procrdureName, DynamicParameters param = null);
        IEnumerable<T> ReturnList<T>(string procrdureName, DynamicParameters param = null);
    }
}