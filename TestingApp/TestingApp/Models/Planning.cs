using System.ComponentModel.DataAnnotations;

namespace TestingApp.Models;
public class Planning
{
    public int Id { get; set; }
    public int Week { get; set; }
    public int Hours { get; set; }
    public int ProjectId { get; set; }  
    public Project Project {  get; set; }   
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }

}
