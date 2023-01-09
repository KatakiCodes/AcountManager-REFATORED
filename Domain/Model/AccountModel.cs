using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccses.Contracts;
using DataAccses.Entity;
using DataAccses.Repositories;
using Domain.ObjectValue;
using System.ComponentModel.DataAnnotations;

namespace Domain.Model
{
    public class AccountModel
    {
        private int id_pk;
        private string plataform;
        private string email;
        private string password;
        private string user;
        private int contact;
        private string password_creator;

        private IAccountRepository accountRepository;
        public EntityState state;

        public int Id_pk { get => id_pk; set => id_pk = value; }
        [Required]
        [RegularExpression("^[a-zA-Z ]+$",ErrorMessage ="The plataform´s name field must contains only letters")]
        public string Plataform { get => plataform; set => plataform = value; }

        [EmailAddress]
        public string Email { get => email; set => email = value; }
        [Required]
        public string Password { get => password; set => password = value; }
        [Required]
        public string User { get => user; set => user = value; }
        public int Contact { get => contact; set => contact = value; }
        public string Password_creator{ get => password_creator; set => password_creator = value; }

        public AccountModel()
        {
            accountRepository = new AccountRepository();
        }

        public string saveChanges()
        {
            
            string message = null;
            try
            {
                var accountModel = new Account();

                accountModel.id_pk = id_pk;
                accountModel.plataform = plataform;
                accountModel.email = email;
                accountModel.password = password;
                accountModel.user = user;
                accountModel.contact = contact;
                accountModel.password_creator = password_creator;
                switch (state)
                {
                    case (EntityState.Added):
                        accountRepository.Add(accountModel);
                        message = "Sucefully record";
                        break;
                    case (EntityState.Deleted):
                        accountRepository.Remove(id_pk);
                        message = "Sucefully removed";
                        break;
                    case (EntityState.Modified):
                        accountRepository.Update(accountModel);
                        message = "Sucefully modified";
                        break;
                }
            }
            catch(Exception error)
            {
                message = error.Message;
            }
            return message;
        }

        public List<AccountModel> GetAll()
        {
            var acountdataList = accountRepository.GetAll();
            var accountList = new List<AccountModel>();
            foreach(Account item in acountdataList)
            {
                accountList.Add(new AccountModel
                {
                    id_pk = item.id_pk,
                    plataform = item.plataform,
                    password = item.password,
                    email = item.email,
                    contact = item.contact,
                    user = item.user,
                    password_creator = item.password_creator
                });
            }
            return accountList;
        }
    }
}
