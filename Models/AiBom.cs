using System;
using System.Collections.Generic;

namespace CookiesSalesSystem.Models;

public partial class AiBom
{
    public int ID { get; set; }

    public string? CreateID { get; set; }

    public DateOnly? CreatDate { get; set; }

    public DateOnly? ModifyDate { get; set; }

    public string? ModifyEmployeeID { get; set; }

    public string? MachineID { get; set; }

    public string? MachineClass { get; set; }

    public string? MachineName { get; set; }

    public string? SupervisorID { get; set; }

    public string? EmployeeName { get; set; }

    public string? DepartmentName { get; set; }

    public DateOnly? AddTime { get; set; }

    public string? WifiSSID { get; set; }

    public string? WifiPassword { get; set; }

    public string? IpAddress { get; set; }

    public string? SubnetMask { get; set; }

    public string? Gateway { get; set; }

    public string? Dns { get; set; }

    public string? Open_ { get; set; }

    public string? Speed { get; set; }

    public string? Optimization { get; set; }

    public string? AlgorithmName { get; set; }

    public string? HyperparameterName { get; set; }

    public string? CrossName { get; set; }
}
