﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostAzureAD.Data {
    public class ApplicationDbContext : IdentityDbContext {
        public ApplicationDbContext
            (DbContextOptions<ApplicationDbContext> options)
            : base(options) { }
    }

}
