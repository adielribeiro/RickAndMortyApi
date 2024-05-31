using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;
using Rm.API.Models;
using Rm.API.Repositories;

namespace Rm.API.Services
{
    public class CharServices : iCharServices
    {
        public readonly ICharRepositories _charRepositories;

        public CharServices(ICharRepositories charRepositories)
        {
            _charRepositories = charRepositories;
        }

        public async Task<Models.Char> GetCharById(int id)
        {
            Models.Char CharRetornado = new Models.Char();
            string url = $"https://rickandmortyapi.com/api/character/{id}";
            using (var _http = new HttpClient())
            {   
                
                    var response = await _http.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        var json  = await response.Content.ReadAsStringAsync();


                        CharRetornado =  JsonSerializer.Deserialize<Models.Char>(json);
       
                    }
                    else
                    {
                        return null;
                    }
            }

           _charRepositories.SalvarChar(CharRetornado);

            return CharRetornado;

        }
      
    }
     
}