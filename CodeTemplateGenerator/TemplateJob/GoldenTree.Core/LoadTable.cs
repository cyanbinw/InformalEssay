using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenTree.Core
{
    public class LoadTable
    {
        public List<ColumnModel> LoadData()
        {
            List<ColumnModel> list = new List<ColumnModel>();
            String connetStr = "server=192.168.2.188;port=3306;user=mac;password=123456; database=production;";
            // server=127.0.0.1/localhost 代表本机，端口号port默认是3306可以不写
            MySqlConnection conn = new MySqlConnection(connetStr);
            try
            {
                conn.Open();//打开通道，建立连接，可能出现异常,使用try catch语句
                Console.WriteLine("已经建立连接");
                //在这里使用代码对数据库进行增删查改

                MySqlCommand cmd = null;
                MySqlDataReader reader = null;
                
                string sql = "show columns from Investment;";
                cmd = new MySqlCommand(sql, conn);
                try
                {
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string t = reader.GetString(0);

                            string ttt = reader.GetString(1);
                            list.Add(new ColumnModel(t,ttt));
                        }
                    }
                    reader.Close();

                }
                catch (Exception e) {  }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return list;
        }
    }

    public class ColumnModel
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public ColumnModel(string name, string type)
        {
            Name = name;
            switch (type.Split(" ")[0])
            {
                case "bit": 
                    Type = "Boolean";
                    break;
                case "bigint": 
                    Type = "Int64";
                    break;
                case "int": 
                    Type = "Int32";
                    break;
                case "smallint": 
                    Type = "Int16";
                    break;
                case "tinyint": 
                    Type = "Byte";
                    break;
                case "numeric":
                case "money":
                case "smallmoney":
                case "decimal": 
                    Type = "Decimal";
                    break;
                case "float": 
                    Type = "Double";
                    break;
                case "real": 
                    Type = "Single";
                    break;
                case "smalldatetime":
                case "timestamp":
                case "datetime": 
                    Type = "DateTime";
                    break;
                case "char":
                case "varchar":
                case "text":
                case "Unicode":
                case "nvarchar":
                case "ntext": 
                    Type = "string";
                    break;
                case "binary":
                case "varbinary":
                case "image": 
                    Type = "Byte[]";
                    break;
                case "uniqueidentifier": 
                    Type = "Guid";
                    break;
                default: 
                    Type = "Object";
                    break;
            }
        }
    }
}
