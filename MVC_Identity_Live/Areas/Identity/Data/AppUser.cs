﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace MVC_Identity_Live.Areas.Identity.Data;

// Add profile data for application users by adding properties to the AppUser class
public class AppUser : IdentityUser
{
    // Burada eklenecek olan alanları property olarak tanımlıyoruz.

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string City { get; set; } // Yeni alan

}

