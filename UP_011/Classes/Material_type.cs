using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP_011.Classes
{
    public class Material_type
    {
        public int Id_material { get; set; }
        public string Type_name { get; set; }
        public int Percent { get; set; }

        public Material_type(int Id_material, string Type_name, int Percent) 
        {
            this.Id_material = Id_material;
            this.Type_name = Type_name;
            this.Percent = Percent;
        }
    }
}
