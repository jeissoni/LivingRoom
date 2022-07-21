﻿namespace LivingRoom.DTOs
{
    public class UserAddressDTO
    {
        public int UserAddressId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public int Zipcode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public UserDTO User { get; set; }
    }
}
