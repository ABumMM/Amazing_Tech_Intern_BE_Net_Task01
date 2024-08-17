﻿using XuongMay.Entity;

namespace XuongMay.Dtos.Responses
{
    public class ApiResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;
        public Category Data { get; internal set; }
    }
}
