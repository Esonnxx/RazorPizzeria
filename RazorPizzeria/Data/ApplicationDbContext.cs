using Microsoft.EntityFrameworkCore;
using RazorPizzeria.Models;


namespace RazorPizzeria.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet< PizzaOrderModel> PizzaOrders { get; set;}

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            //是 ApplicationDbContext 類別的建構子，它接受一個 DbContextOptions<ApplicationDbContext> 參數。
            //DbContextOptions 是用於配置和設定資料庫連線、記錄、快取等選項的容器。
            //這個建構子的作用是接受這些選項，並將它們傳遞給基底類別的建構子（base(options)），以初始化資料庫上下文。

        }
    }
}
