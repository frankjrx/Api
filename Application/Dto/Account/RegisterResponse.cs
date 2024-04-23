using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.User
{
    public class RegisterResponse
    {
        public bool HasError { get; set; }
        public string? Error { get; set; }
    }
}
