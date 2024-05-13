using DemoLibrary;

namespace AccessModifiersDemo
{
    public class ModifiedDataAccess : DataAccess
    {
        public void GetUnsecuredConnectionInfo()
        {
            GetConnectionString();
        }
    }
}
