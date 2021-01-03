
namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// Represents the unique identifier for this person
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents the first name of this person
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Represents the last name of this person
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Represents the email adress of this person
        /// </summary>
        public string EmailAdress { get; set; }
        /// <summary>
        /// Represents the cellphone number of this person
        /// </summary>
        public string CellphoneNumber { get; set; }

        public string FullName 
        { 
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
