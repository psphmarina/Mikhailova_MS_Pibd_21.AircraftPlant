﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AircraftBuildingPlantServiceDAL.BindingModel
{
    [DataContract]
    public class WarehouseBindingModel
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string WarehouseName { get; set; }
    }
}
