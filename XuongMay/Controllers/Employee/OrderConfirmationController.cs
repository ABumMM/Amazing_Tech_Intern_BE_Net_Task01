﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using XuongMay.Dtos.Requests;
using XuongMay.Services.IServices;

namespace XuongMay.Controllers.Employee
{
    [Authorize(Roles = "admin,employee")]
    [ApiController]
    [Route("api/orders/employee/confirm")]
    public class OrderConfirmationController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderConfirmationController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        // xác nhận đơn hàng
        [HttpPut]
        public async Task<IActionResult> ConfirmOrder([FromBody] UpdateOrderStatusRequest request)
        {
            await _orderService.ConfirmOrderAsync(request);
            return Ok(new { Success = true, Message = "Đã xác nhận đơn hàng." });
        }
    }
}
