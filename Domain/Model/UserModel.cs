using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Domain.ObjectValue;
using DataAccses.Contracts;
using DataAccses.Entity;
using DataAccses.Repositories;
using System.Data.OleDb;

namespace Domain.Model
{
    public class UserModel
    {
        private int id_pk;
        private string password;
        private string alt_password;

        private IUserRepository userRepository;
        private EntityState state {get; set; }
        
        public int Id_pk { get => id_pk; set => id_pk = value; }
        [Required]
        public string Password { get => password; set => password = value; }
        [Required]
        public string Alt_password { get => alt_password; set => alt_password = value; }

        public UserModel()
        {
          userRepository = new UserRepository();
        }
        public string saveChages()
        {
            string message = null;
            try
            {
                var userModel = new User();
                userModel.id_pk = this.id_pk;
                userModel.password = this.password;
                userModel.alt_password = this.alt_password;

                switch (state)
                {
                    case (EntityState.Added):
                        userRepository.Add(userModel);
                        message = "Sucefull record";
                        break;              
                    case (EntityState.Deleted):
                        userRepository.Remove(id_pk);
                        message = "Sucefully Removed";
                        break;           
                    case (EntityState.Modified):
                        userRepository.Update(userModel);
                        message = "Sucefully updated";
                        break;
                }
            }
            catch (Exception error)
            {
                message = error.Message;
            }
            return message;
        }

        public IEnumerable<UserModel> getAll()
        {
            var UserDataModel = userRepository.GetAll();
            var userList = new List<UserModel>();

            foreach(User item in UserDataModel)
            {
                userList.Add(new UserModel
                {
                    id_pk = item.id_pk,
                    password = item.password,
                    alt_password = item.alt_password
                });
            }
            return userList;
        }
    }
}
