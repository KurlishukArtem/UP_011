using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP_011.Classes
{
    public class partners
    {
        public int Id { get; set; }
        public string Type_partner { get; set; }
        public string Name_partner { get; set; }
        public string Director { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public string Legal_adress { get; set; }
        public long INN { get; set; }
        public int Raiting { get; set; }

        public partners(int Id, string Type_partner, string Name_partner, string Director, string Email, long Phone, string Legal_adress, long INN, int Raiting)
        {
            this.Id = Id;
            this.Type_partner = Type_partner;
            this.Name_partner = Name_partner;
            this.Director = Director;
            this.Email = Email;
            this.Phone = Phone;
            this.Legal_adress = Legal_adress;
            this.INN = INN;
            this.Raiting = Raiting;
        }
    }
}
