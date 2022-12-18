﻿using AutoMapper;
using Hola.Api.Models;
using Hola.Api.Service;
using Hola.Api.Service.GrammarServices;
using Hola.Api.Service.UserManualServices;
using Hola.Core.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Hola.Api.Controllers
{
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService _notiservice;
        private readonly IMapper _mapperService;
        public NotificationController(INotificationService notiservice,
            IMapper mapperService)
        {
            _notiservice = notiservice;
            _mapperService = mapperService;
        }


        [HttpGet("Notification")]
        [Authorize]
        public async Task<JsonResponseModel> GetAll()
        {
            try
            {
                // Lấy ra thông tin thông báo của User
                int userid = int.Parse(User.Claims.FirstOrDefault(c => c.Type == "UserId").Value);
                var result = await _notiservice.GetAllAsync(x=>x.FK_UserId==userid && x.IsRead==false);
                return JsonResponseModel.Success(result);
            }
            catch (System.Exception Ex)
            {
                return JsonResponseModel.SERVER_ERROR(Ex.Message);
           
            }
        }

        [HttpPost("watched")]
        [Authorize]
        public async Task<JsonResponseModel> Watched([FromBody] ReadNotificationRequest model)
        {
            try
            {
                // Lấy ra thông tin thông báo của User
                int userid = int.Parse(User.Claims.FirstOrDefault(c => c.Type == "UserId").Value);
                var noti = await _notiservice.GetFirstOrDefaultAsync(x=>x.FK_UserId==userid && x.IsRead==false && x.Pk_Id==model.PK_notification_Id);
                if (noti!=null)
                {
                    noti.IsRead = true;
                    var updateResponse =  await _notiservice.UpdateAsync(noti);
                    return JsonResponseModel.Success(updateResponse);
                }
                else
                {
                    return JsonResponseModel.Success("Đọc thông báo không thành công");
                }  
            }
            catch (System.Exception Ex)
            {
                return JsonResponseModel.SERVER_ERROR(Ex.Message);

            }
        }
    }
}
