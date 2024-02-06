using System;
using System.Collections.Generic;

namespace RKSOFTWARESOLUTIONS.Models;

public partial class RegistrationForm
{
    public int? Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? NewUserName { get; set; }

    public int? NewPassword { get; set; }

    public int? ConfirmPassword { get; set; }
}
