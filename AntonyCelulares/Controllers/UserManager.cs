using AntonyCelulares.Data;
using AntonyCelulares.Data.Entities;
using AntonyCelulares.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace AntonyCelulares.Controllers
{
    public class UserManager
    {
        private readonly DataContext _context;

        public UserManager(IServiceProvider service)
        {
            _context = service.GetRequiredService<DataContext>();
        }
        public async Task<Result> GetAsync()
        {
            Result result = new Result { IsSuccess = true };
            try
            {
                List<UserEntity> usuarios = await _context.Usuarios
               .Include(u => u.Avatar)
               .ToListAsync();
                if (usuarios == null)
                {
                    result.IsSuccess = false;
                    result.Message = $"No data found.";

                }
                else
                {
                    result.Data = usuarios;
                    result.Message = $"{usuarios.Count} Users found";
                }
            }
            catch (Exception ex)
            {

                result.IsSuccess = false;
                result.Message = ex.Message;
            }


            return result;

        }
        public async Task<Result> GetAsync(Guid id)
        {
            Result result = new Result { IsSuccess = true };
            try
            {
                UserEntity usuario = await _context.Usuarios.FindAsync(id);
                if (usuario == null)
                {
                    result.IsSuccess = false;
                    result.Message = $"No data found.";

                }
                else
                {
                    result.Data = usuario;
                    result.Message = $"User Found";
                }
            }
            catch (Exception ex)
            {

                result.IsSuccess = false;
                result.Message = ex.Message;
            }


            return result;

        }
        private async Task<Result> InsertAsync(UserEntity user)
        {
            Result result = new Result { IsSuccess = true };
            try
            {
                Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<UserEntity> entityEntry = await _context.AddAsync(user);
                if (await _context.SaveChangesAsync() > 0)
                {
                    result.Data = entityEntry.Entity;
                    result.Message = "User  save Successfully";
                }
                else
                {
                    result.IsSuccess = false;
                    result.Message = "User could not be save Successfully";
                }


            }
            catch (Exception ex)
            {

                result.IsSuccess = false;
                result.Message = ex.Message;
            }


            return result;
        }
        private async Task<Result> UpdateAsync(UserEntity user)
        {
            Result result = new Result { IsSuccess = true };
            try
            {
                UserEntity userFound = await _context.Usuarios.FindAsync(user.Id);

                if (userFound != null)
                {
                    userFound = user;
                   
                    if (await _context.SaveChangesAsync() > 0)
                    {
                        result.Data = userFound;
                        result.Message = "User updated Successfully";
                    }
                    else
                    {
                        result.IsSuccess = false;
                        result.Message = "There were something wrong while updating user";
                    }
                }
                else
                {
                    result.IsSuccess = false;
                    result.Message = "User could not be updated Successfully";
                }


            }
            catch (Exception ex)
            {

                result.IsSuccess = false;
                result.Message = ex.Message;
            }


            return result;
        }
        public async Task<Result> InsertOrUpdateAsync(UserEntity user)
        {
            Result result = new Result { IsSuccess = true };
            try
            {
                UserEntity usuario = await _context.Usuarios.FindAsync(user.Id);
                if (usuario == null)
                {

                    result = await InsertAsync(user);

                }
                else
                {
                    result = await UpdateAsync(user);
                }
            }
            catch (Exception ex)
            {

                result.IsSuccess = false;
                result.Message = ex.Message;
            }


            return result;
        }
        public async Task<Result> DeliteAsync(UserEntity user)
        {
            Result result = new Result { IsSuccess = true };
            try
            {
                var entityEntry = _context.Usuarios.Remove(user);
                if (await _context.SaveChangesAsync() > 0)
                {

                    result.Data = entityEntry.Entity;
                    result.Message = "User deleted successfully";

                }
                else
                {
                    result.IsSuccess = false;
                    result.Message = "There was a Error while deleting this user";
                }
            }
            catch (Exception ex)
            {

                result.IsSuccess = false;
                result.Message = ex.Message;
            }


            return result;
        }

    }
}
