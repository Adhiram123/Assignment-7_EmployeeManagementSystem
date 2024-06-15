﻿using EmployeeManagementSystem.DTO;
using EmployeeManagementSystem.Interface;
using EmployeeManagementSystem.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Controllers
{
    [Route("api/[Controller]/[action]")]
    [ApiController]
    public class AdditionalEmployeeDetails : Controller
    {
        public readonly IAdditionInfo_Serivice _additionalService;
        public  AdditionalEmployeeDetails(IAdditionInfo_Serivice additionalService)
        {

            _additionalService = additionalService;
        }

        [HttpPost]
        public async Task<IActionResult> AddAdditionalEmployeeDetails(AdditionalInfoDTO additonalInfoDto)
        {
            var response = await _additionalService.AddEmployeeDetails(additonalInfoDto);

            if (response != null)
            {
                return Ok(response);
            }
            else
            {
                return Ok("It is Null ");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployeeByUid(String uid)
        {
            var response = await _additionalService.GetEmployeeByUid(uid);

            if (response != null)
            {
                return Ok(response);
            }
            else
            {
                return Ok("Enterd Id is Invalid");
            }
        }

        [HttpPost]
        public async Task<IActionResult> UpdateDetailsOfAdditionalEmployeeDetails(AdditionalInfoDTO additionalInfoDto)
        {

            var response = await _additionalService.Update(additionalInfoDto);

            if (response != null)
            {
                return Ok(response);
            }
            else
            {
                return Ok("Enterd Id is Invalid");
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteEmployee(string uid)
        {
            var response = await _additionalService.Delete(uid);

            return Ok("delete succserfully");
        }

    }
}