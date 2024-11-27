using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using UP_011.Classes;
using UP_011.Classes.Common;

namespace UP_011.Classes.Contexts
{
    public class Material_typeContext : Material_type
    {
        public Material_typeContext(int Id_material, string Type_name, int Percent) : base(Id_material, Type_name, Percent)
        {
            
        }
        public static List<Material_typeContext> AllMaterials()
        {
            List<Material_typeContext> allMaterials = new List<Material_typeContext>();
            string str = $"SELECT * FROM Material_type";
            MySqlConnection connection = Connection.OpenConnection();
            MySqlDataReader sa = Common.Connection.Query(str, connection);
            while (sa.Read())
            {
                allMaterials.Add(new Material_typeContext(
                    sa.GetInt32(0),
                    sa.GetString(1),
                    sa.GetInt32(2)
                    ));
            }
            Connection.CloseConnection(connection);
            return allMaterials;
        }
    }
}
