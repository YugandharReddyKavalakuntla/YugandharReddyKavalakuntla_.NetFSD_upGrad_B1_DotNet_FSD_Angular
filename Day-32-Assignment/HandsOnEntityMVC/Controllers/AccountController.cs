using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using HandsOnEntityMVC.Repositories;
using HandsOnEntityMVC.Entity;

namespace HandsOnEntityMVC.Controllers{

    public class AccountController : Controller {

        private readonly AccountRepository _repo;

        public AccountController(){
            _repo = new AccountRepository();
        }

        
        public IActionResult Index(){
            var Accounts = _repo.GetAccounts();
            return View(Accounts);
        }

       

        public IActionResult Details(int id){
            var Account = _repo.GetAccount(id);
            return View(Account);

        }

        public IActionResult Edit(int id)
        {
            var account = _repo.GetAccount(id);
            if (account == null)
                return NotFound();

            return View(account);
        }

        [HttpPost]
     

        public IActionResult Edit(Account account){
            _repo.EditAccount(account);
            return RedirectToAction("Index");
        }

       

        public IActionResult Delete(int id){
            _repo.DeleteAccount(id);
            return RedirectToAction("Index");
            
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(Account account){
            _repo.AddAccount(account);
            return RedirectToAction("Index");
        }








    }




}