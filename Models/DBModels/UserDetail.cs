using System;
using System.Collections.Generic;

namespace WebApi.Models.DBModels
{
    public partial class UserDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Otp { get; set; }
        public sbyte IsConsumer { get; set; }
        public sbyte ActiveStatus { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
