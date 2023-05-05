using System.ComponentModel.DataAnnotations;

namespace TestingApp.Models;
public class Planning
{
    public int Id { get; set; }
    public int Week { get; set; }
    public int Hours { get; set; }

}