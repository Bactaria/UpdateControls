using UpdateControls;

namespace UpdateControls.UnitTest.ContactListData
{
    public class Contact
    {
        private string _firstName;
        private string _lastName;

        #region Independent properties
        // Generated by Update Controls --------------------------------
        private Independent _indFirstName = new Independent();
        private Independent _indLastName = new Independent();

        public string FirstName
        {
            get { _indFirstName.OnGet(); return _firstName; }
            set { _indFirstName.OnSet(); _firstName = value; }
        }

        public string LastName
        {
            get { _indLastName.OnGet(); return _lastName; }
            set { _indLastName.OnSet(); _lastName = value; }
        }
        // End generated code --------------------------------
        #endregion
    }
}
