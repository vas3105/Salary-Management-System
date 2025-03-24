namespace DBMSproj.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class AttendanceService
{
    private List<LeaveApplication> leaveApplications = new List<LeaveApplication>();

    public async Task AddLeaveApplicationAsync(LeaveApplication leave)
    {
        // Simulate a delay for an async operation (like saving to a database)
        await Task.Delay(500);
        leaveApplications.Add(leave);
    }

    public List<LeaveApplication> GetLeaveApplications()
    {
        return leaveApplications;
    }
}

public class LeaveApplication
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Type { get; set; }
    public string Reason { get; set; }
    public string Status { get; set; } = "Waiting";
}
