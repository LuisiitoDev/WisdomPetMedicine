﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WisdomPetMedicine.Rescue.Domain.Dto;

namespace WisdomPetMedicine.Rescue.Domain.Entities;

public class RescuedAnimal
{
    public Guid Id { get; init; }
    public AdopterId AdopterId { get; private set; }
    public RescuedAnimalAdoptionStatus AdoptionStatus { get; private set; }
    public RescuedAnimal(RescuedAnimalId id)
    {
        Id = id;
    }

    protected RescuedAnimal()
    {

    }

    public void RequestToAdopt(AdopterId adopterId)
    {
        AdopterId = adopterId;
        AdoptionStatus = RescuedAnimalAdoptionStatus.PendingReview;
    }
}
