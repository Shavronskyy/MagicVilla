﻿namespace MagicVilla_Web.Models.Dto
{
    public class LoginResponseDTO
    {
        UserDTO User { get; set; }
        public string Token { get; set; }
    }
}
