﻿using AbstractPrintingHouseBusinessLogic.BindingModels;
using AbstractPrintingHouseBusinessLogic.Interfaces;
using AbstractPrintingHouseBusinessLogic.ViewModels;
using AbstractPrintingHouseDatabaseImplement;
using AbstractPrintingHouseDatabaseImplement.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AbstractPrintingHouseDatabaseImplement.Implements
{
    public class ClientLogic : IClientLogic
    {
        public void CreateOrUpdate(ClientBindingModel model)
        {
            using (var context = new AbstractPrintingHouseDatabase())
            {
                Client element = context.Clients.FirstOrDefault(rec => rec.Email == model.Login && rec.Id != model.Id);

                if (element != null)
                {
                    throw new Exception("Уже есть клиент с таким именем");
                }

                if (model.Id.HasValue)
                {
                    element = context.Clients.FirstOrDefault(rec => rec.Id == model.Id);

                    if (element == null)
                    {
                        throw new Exception("Клиент не найден");
                    }
                }
                else
                {
                    element = new Client();
                    context.Clients.Add(element);
                }

                element.Email = model.Login;
                element.FIO = model.FIO;
                element.Password = model.Password;

                context.SaveChanges();
            }
        }

        public void Delete(ClientBindingModel model)
        {
            using (var context = new AbstractPrintingHouseDatabase())
            {
                Client element = context.Clients.FirstOrDefault(rec => rec.Id == model.Id);

                if (element != null)
                {
                    context.Clients.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }

        public List<ClientViewModel> Read(ClientBindingModel model)
        {
            using (var context = new AbstractPrintingHouseDatabase())
            {
                return context.Clients
                .Where(rec => model == null || rec.Id == model.Id
                || rec.Email == model.Login && rec.Password == model.Password)
                .Select(rec => new ClientViewModel
                {
                    Id = rec.Id,
                    FIO = rec.FIO,
                    Email = rec.Email,
                    Password = rec.Password
                })
                .ToList();
            }
        }
    }
}
