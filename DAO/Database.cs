// DAO/Database.cs
using MySql.Data.MySqlClient;

namespace bts_gsb.DAO
{
    public class Database
    {
        private readonly string myConnetionString =
            "server=localhost;port=3307;uid=root;pwd=rootpassword;database=bts-gsb;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(myConnetionString);
        }
    }
}