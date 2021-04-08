using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class GuestResponse  //POCO - Plain, Old, C#, Object
    {
        //FIELDS
        private string name;     //Unlimited values can be stored
        private string email;    //Unlimited values can be stored
        private string phone;    //Unlimited values can be stored
        private bool? willAttend; //True, False, Null

        //PROPERTIES

        //CONSTRUCTORS


        //METHODS
        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            if(name != null &&)
        }
    }
}
