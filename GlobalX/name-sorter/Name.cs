using System;

namespace name_sorter
{

    //Name class processes raw string of full name into
    //an object containing first name and last name information
    public class Name
    {
        private string firstName;
        private string lastName;

        //constructor takes raw string and splits it to first and last name
        public Name(string rawName)
        {
            if (rawName != null)
            {
                int divisionIndex = rawName.LastIndexOf(" ");
                SetFirstName(rawName.Substring(0, divisionIndex));
                SetLastName(rawName.Substring(divisionIndex + 1));
            }
        }

        //returns sortable name with last name in front of first name
        public string GetSortableName()
        {
            return $"{GetLastName()} {GetFirstName()}";
        }

        //returns readable string version of Name
        public override string ToString()
        {
            return ($"{firstName} {lastName}");
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        //override equals method, because the base function doesn't compare it correctly
        public override bool Equals(object obj)
        {
            if (obj != null && GetType() == obj.GetType() && ((Name)obj).ToString() == ToString()){

                return true;
            }
            return false;
        }

        //setter for first and last names
        public void SetFirstName(string _firstName) { firstName = _firstName; }
        public void SetLastName(string _lastName) { lastName = _lastName; }

        //getter for first and last names
        public string GetFirstName() { return firstName; }
        public string GetLastName() { return lastName; }

    }
}