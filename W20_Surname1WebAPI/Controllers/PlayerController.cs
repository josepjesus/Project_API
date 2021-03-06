﻿using Dapper;
using Microsoft.AspNet.Identity;
using System;
using System.Data;
using System.Linq;
using System.Web.Http;
using W20_Surname1WebAPI.Models;

namespace W20_Surname1WebAPI.Controllers
{
    [Authorize]
    [RoutePrefix("api/Player")]
    public class PlayerController : ApiController
    {

        // POST api/Player/RegisterPlayer
        [HttpPost]
        [Route("RegisterPlayer")]
        public IHttpActionResult RegisterPlayer(PlayerModel player)
        {
            using (IDbConnection cnn = new ApplicationDbContext().Database.Connection)
            {
                string sql = "INSERT INTO dbo.Players(Id, FirstName, LastName, NickName, City, Email, BirthDay, ConnectedSince) " +
                    $"VALUES('{player.Id}','{player.FirstName}','{player.LastName}','{player.NickName}','{player.City}'," +
                    $"'{player.Email}','{player.BirthDay}','{DateTime.Now}')";
                try
                {
                    cnn.Execute(sql);
                }
                catch (Exception ex)
                {
                    return BadRequest("Error inserting player in database: " + ex.Message);
                }

                return Ok();
            }
        }

        // GET api/Player/GetPlayerInfo
        [HttpGet]
        public PlayerModel GetPlayerInfo()
        {
            string authenticatedAspNetUserId = RequestContext.Principal.Identity.GetUserId();
            using (IDbConnection cnn = new ApplicationDbContext().Database.Connection)
            {
                string sql = $"SELECT Id, FirstName, LastName, NickName, City, Email, BirthDay, ConnectedSince " +
                    $"WHERE Id LIKE '{authenticatedAspNetUserId}'";
                var player = cnn.Query<PlayerModel>(sql).FirstOrDefault();
                return player;
            }
        }

    }
}
