#pragma warning disable

using Microsoft.EntityFrameworkCore;
namespace TicketsHelper.Models;

public class MyContext : DbContext 
{ 
    public MyContext(DbContextOptions options) : base(options) { }

}