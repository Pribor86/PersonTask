using System;
namespace PersonTaskAbstract
{
    public class Person
    {
        
            private string firstName, lastName, idNumber;

            public string FirstName
            {
                get { return firstName; }
            }

            public string LastName
            {
                get { return lastName; }
            }

            public string IdNumber
            {
                get { return idNumber; }
            }
        


            public Person(string firstName, string lastName, string idNumber)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.idNumber = idNumber;
            }

            public override string ToString()
            {
                return String.Format("{0,-10} {1,-20} ID:{2,-11} ", firstName, lastName, idNumber);
            }//end ToString

        //public int CompareTo(object obj)
        //{
        //    Person temp = (Person)obj;
        //    return firstName.CompareTo(temp.FirstName);
        //}//end CompareTo

        public override bool Equals(object obj)
        {
            return obj is Person person &&
                   firstName == person.firstName &&
                   lastName == person.lastName &&
                   idNumber == person.idNumber;
        }//end Equals

        public override int GetHashCode()
        {
            return HashCode.Combine(firstName, lastName, idNumber);
        }//end GetHashCode
    }
}
