﻿using Microsoft.Azure.CosmosRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainCertificatesIssuer.domain.Models.Trainee
{
    public class Trainee : Item
    {
        public string FirstName { get; set; }
        public string LasttName { get; set; }
        public string EmailAddress { get; set; }
    }
}
