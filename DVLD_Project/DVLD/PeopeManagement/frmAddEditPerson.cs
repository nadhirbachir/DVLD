using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmAddEditPerson : Form
    {
        // Delegate definition for passing the updated PersonID back to the calling form
        public delegate void DataBackEventHandler(object sender, int PersonID);

        // Event that will be invoked to pass the updated PersonID
        public DataBackEventHandler DataBack;

        int _PersonID = -1; // Default value for the PersonID (assumed to be -1 for a new person)

        public frmAddEditPerson(int PersonID = -1)
        {
            InitializeComponent();

            // Store the provided PersonID (if -1, it indicates a new person; otherwise, an existing person)
            _PersonID = PersonID;

            // Attach the GetPersonID method to the IDBack event of the ctrlEditPerson1 control.
            // When the event is fired, the PersonID will be passed to the GetPersonID method.
            ctrlEditPerson1.IDBack += this.GetPersonID;

            // Load the person's information into the user control.
            // If PersonID is -1 (indicating a new person), it will initiate the process of adding a new person.
            // Otherwise, it will load the details of the existing person for editing.
            ctrlEditPerson1.LoadPersonInfo(PersonID);

            // Attach the CloseForm method to the CloseForm event of the ctrlEditPerson1 control.
            // When this event is triggered (when the user is done and the form is closed), CloseForm will be executed.
            ctrlEditPerson1.CloseForm += this.CloseForm;
        }

        private void GetPersonID(object sender, int PersonID)
        {
            // Update the _PersonID field when the IDBack event is triggered.
            // This is the new PersonID passed back from the user control.
            _PersonID = PersonID;
        }

        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {
            // Handle any additional loading logic here if needed (currently empty).
        }

        private void CloseForm(object sender)
        {
            // This method will be triggered when the user control signals that it should close.

            // First, check if the person with the given _PersonID exists using the clsPerson utility.
            if (clsPerson.isPersonExists(_PersonID))
            {
                // If the person exists, invoke the DataBack event, passing the updated _PersonID back to the calling form.
                DataBack?.Invoke(this, _PersonID);
            }

            // Close the form after handling the data.
            this.Close();
        }

    }
}
