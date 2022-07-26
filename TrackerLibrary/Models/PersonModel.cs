using System;
using System.Collections.Generic;

namespace TrackerLibrary.Models;
public class PersonModel
{
    /// <summary>
    /// Represents the first name of this particular person
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// Represents the last name of this particular person
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// Represents the email address of this particular person
    /// </summary>
    public string EmailAddress { get; set; }

    /// <summary>
    /// Represents the cell phone number of this particular person
    /// </summary>
    public string CellphoneNumber { get; set; }
}
