﻿using TakeFoodAPI.Model.Entities;

namespace StoreService.Model.Entities.Store;

public class StoreCategory:ModelMongoDB
{
    public string CategoryId { get; set; }
    public string StoreId { get; set; }
}
