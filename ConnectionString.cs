

namespace API
{
    public class ConnectionString
    {
        public string cs {get; set;}

        public ConnectionString()
        {
            string server = "grp6m5lz95d9exiz.cbetxkdyhwsb.us-east-1.rds.amazonaws.com";
            string database = "ki0rjid2kxi6skes";
            string port = "3306";
            string userName = "o9f2hp7g7jrao44r";
            string password = "kvqdleuhj527isj3";

            cs = $@"server = {server}; database = {database}; port = {port}; userName = {userName}; password = {password};";
        }
    }
}