using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
    public class Die
    {
        //Data Members
        //Usually Private
        private int _Side;
        private string _color;
        
       
        //properties
        //are responsible to assigning and retrieving data
        //  to/from their associated data member 
        // retrieving data from a data member uses the get{}
        // assigning data to a data member uses the set{}
        // properties need to be exposed to outside users
        //properties will have a return datatype but no parameter list

        //Fully Implemented Property
        //has a defined Data member that the developer
        //can directly access

        public int Side
        {
            get
            {
                //returns data of a specific datatype
                return _Side;
            }
            set
            {
                //assigns a supplied value to the data member
                //the supplied value is located in the key word: value
                //optionally Include data value validation to ensure
                // an appropriate value has been supplied 
                if (value >= 6 && value <= 20)
                {

                }
                else
                {
                    //this is an unacceptable value
                    //issue a user friendly error message
                    throw new Exception("Die cannot be" + value.ToString() + "Sided. Die must be between 6 and 20 sided.");
                }
                _Side = value;
            }
        }
        //Auto Implemented Property
        //NO Data member defination
        //the data member is internally created for you 
        //the data member data type is taken from your return datatype
        //specified on the property header
        //auto implented property is usually used when there is no need to internal validation
        // access to a value managed by an auto implenmented property Must be done via the property
        public int facevalue
        {
            get;
            set;
        }

    }
}
