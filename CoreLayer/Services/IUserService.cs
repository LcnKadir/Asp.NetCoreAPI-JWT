﻿using CoreLayer.DTOs;
using SharedLibrary.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Services
{
    public interface IUserService
    {
        Task<Response<UserAppDto>> CreatUserAsync(CreatUserDto creatUserDto);
        Task<Response<UserAppDto>> GetUserByNameAsync(string userName);
    }
}
