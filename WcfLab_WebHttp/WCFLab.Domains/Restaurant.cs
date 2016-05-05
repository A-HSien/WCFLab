using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WCFLab.Domains
{
    [DataContract]
    public class Restaurant
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string PhoneNumber { get; set; }

        public Restaurant() { }

        public Restaurant(dynamic dynamicRestaurant) {
            this.Id= dynamicRestaurant["Id"];
            this.Name = dynamicRestaurant["Name"];
            this.Address = dynamicRestaurant["Address"];
            this.PhoneNumber = dynamicRestaurant["PhoneNumber"];
        }
    }
}
