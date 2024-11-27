using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using UP_011.Classes.Common;

namespace UP_011.Classes.Contexts
{
    public class PartnersContext : partners
    {

        public PartnersContext(int Id, string Type_partner, string Name_partner, string Director, string Email, long Phone, string Legal_adress, long INN, int Raiting)
            : base (Id, Type_partner, Name_partner, Director, Email, Phone, Legal_adress, INN, Raiting) { }

        public static List<PartnersContext> AllParnters()
        {
            List<PartnersContext> allPartners = new List<PartnersContext>();
            string str = "SELECT * FROM partners";
            MySqlConnection connection = Connection.OpenConnection();
            MySqlDataReader sa = Connection.Query(str, connection);
            while (sa.Read()) {
                allPartners.Add(new PartnersContext(
                    sa.GetInt32(0),
                    sa.GetString(1),
                    sa.GetString(2),
                    sa.GetString(3),
                    sa.GetString(4),
                    sa.GetInt64(5),
                    sa.GetString(6),
                    sa.GetInt64(7),
                    sa.GetInt32(8)
                    ));
            }
            Connection.CloseConnection(connection);
            return allPartners;
        }
        public void Add()
        {
            string str = $"INSERT INTO `UP_bd`.`partners` (`type_partner`, `name_partner`, `director`, `e-mail`, `phone`, `legal_adress`, `INN`, `raiting`) VALUES " +
                $"('{this.Type_partner}', '{this.Name_partner}', '{this.Director}', '{this.Email}', '{this.Phone}', '{this.Legal_adress}', '{this.INN}', '{this.Raiting}');";
            MySqlConnection connection = Connection.OpenConnection();
            Connection.Query(str, connection);
            Connection.CloseConnection(connection);
        }
        public void Edit()
        {
            string str = $"UPDATE `UP_bd`.`partners` SET `type_partner` = '{this.Type_partner}', `name_partner` = '{this.Name_partner}', `director` = '{this.Director}', `e-mail` = '{this.Email}', `phone` = '{this.Phone}', `legal_adress` = '{this.Legal_adress}'," +
                $" `INN` = '{this.INN}', `raiting` = '{this.Raiting}'  WHERE (`id` = '{this.Id}');";
            MySqlConnection connection = Connection.OpenConnection();
            Connection.Query(str, connection);
            Connection.CloseConnection(connection);
        }
        public void Delete() 
        {
            string str = $"DELETE FROM `UP_bd`.`partners` WHERE (`id` = '{this.Id}');";
            MySqlConnection connection = Connection.OpenConnection();
            Connection.Query(str, connection);
            Connection.CloseConnection(connection);
        }
    }
}
