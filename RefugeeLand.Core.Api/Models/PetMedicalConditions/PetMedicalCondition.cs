﻿using System;
using RefugeeLand.Core.Api.Models.MedicalConditions;
using RefugeeLand.Core.Api.Models.Pets;

namespace RefugeeLand.Core.Api.Models.PetMedicalConditions
{
    public class PetMedicalCondition
    {
        public Guid MedicalConditionId { get; set; }
        public MedicalCondition MedicalCondition { get; set; }

        public Guid PetId { get; set; }
        public Pet Pet { get; set; }
    }
}