using System;
using System.Collections.Generic;
using System.Text;
using HandsOnEntityMVC.Entity;
using HandsOnEntityMVC.Database;
using Microsoft.EntityFrameworkCore;

namespace HandsOnEntityMVC.Repositories{

    public class AccountRepository{

        private readonly AppDbContext _Context;

        public AccountRepository(){
            _Context = new AppDbContext();
        }

        public void AddAccount(Account account){
            _Context.Accounts.Add(account);
            _Context.SaveChanges();

        }

        public void EditAccount(Account account){
            _Context.Accounts.Update(account);
            _Context.SaveChanges();
        }

      

        public void DeleteAccount (int id){
            var account = _Context.Accounts.Find(id);
            _Context.Accounts.Remove(account);
            _Context.SaveChanges();
        }

        public Account GetAccount(int id){
            return _Context.Accounts.Find(id);
        }

        public List<Account> GetAccounts(){
            return _Context.Accounts.ToList();
        }




    }




}