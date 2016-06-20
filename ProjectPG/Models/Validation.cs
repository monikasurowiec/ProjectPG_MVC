using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPG.Models
{
    public  class  Validation
    {
        public static bool FormValidation(string firstName, string secondName, string email, string phone)
        {

            bool valid = false;

            bool fName = InputValidation(firstName, TypeValidation.name);
            bool sName = InputValidation(secondName, TypeValidation.name);
            bool mail = InputValidation(email, TypeValidation.mail);
            bool telephone = InputValidation(phone, TypeValidation.telephone);

            if (fName == true && sName == true && mail == true && telephone)
            {
                valid = true;
                return valid;
            }
            else
            {
                valid = false;
                return valid;
            }
        }

        private static bool InputValidation(string text, TypeValidation typeVal)
        {
            switch (typeVal)
            {

                case TypeValidation.mail:

                    break;

                case TypeValidation.telephone:

                    break;

                case TypeValidation.name:

                    break;
            }
            return true;

        }


        private enum TypeValidation
        {
            telephone,
            mail,
            name
        }
    }
}

    
