using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPOSITORIES.Entities
{
    public enum EGender { Male, Female }
    public enum EHMO { Maccabi, Meuchedet,Klallit,Leumit }

    public class User
    {
        
       public int UserId { get; set; } 
        public string Name { get; set; }
        public string FamilyName { get; set; }
        public string TZ { get; set; }
        public DateTime DOB { get; set; }
        //אולי לעשות בenum
        public EGender Gender { get; set; }
        public EHMO HMO { get; set; }
       public List<Child> Children { get; set; }



    }
}
