using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wardrobe
{
    internal partial class Wardrobe_Context : DbContext
    {
        // Для работы с БД MS SQL Server необходимо добавить пакет:
        // Microsoft.EntityFrameworkCore.SqlServer(представляет функциональность Entity Framework для работы с MS SQL Server)

        // Microsoft.Extensions.Configuration.Json. Этот пакет специально предназначен для работы с конфигурацией в формате json.

        public Wardrobe_Context(DbContextOptions<Wardrobe_Context> options)
           : base(options)
        {
            if (Database.EnsureCreated())
            {
                Clothes_style style1 = new Clothes_style {Style_name = "Повседневный" };
                Clothes_style style2 = new Clothes_style { Style_name = "Спортивный" };
                Clothes_style style3 = new Clothes_style { Style_name = "Вечерний" };
                Clothes_style style4 = new Clothes_style { Style_name = "Рабочий" };

                clothes_styles.Add(style1);
                clothes_styles.Add(style2);
                clothes_styles.Add(style3);
                clothes_styles.Add(style4);

                Clothes_type type1 = new Clothes_type { Type_name = "верх" };
                Clothes_type type2 = new Clothes_type { Type_name = "низ" };
                Clothes_type type3 = new Clothes_type { Type_name = "платье/костюм" };
                Clothes_type type4 = new Clothes_type { Type_name = "обувь" };

                clothes_types.Add(type1);
                clothes_types.Add(type2);
                clothes_types.Add(type3);
                clothes_types.Add(type4);

                Colors color1 = new Colors { Color_name = "Белый" };
                Colors color2 = new Colors { Color_name = "Черный" };
                Colors color3 = new Colors { Color_name = "Бежевый" };
                Colors color4 = new Colors { Color_name = "Красный" };
                Colors color5 = new Colors { Color_name = "Зеленый" };
                Colors color6 = new Colors { Color_name = "Желтый" };
                Colors color7 = new Colors { Color_name = "Коричневый" };
                Colors color8 = new Colors { Color_name = "Синий" };
                Colors color9 = new Colors { Color_name = "Серый" };
                Colors color10 = new Colors { Color_name = "С рисунком" };

                colors.Add(color1);
                colors.Add(color2);
                colors.Add(color3);
                colors.Add(color4);
                colors.Add(color5);
                colors.Add(color6);
                colors.Add(color7);
                colors.Add(color8);
                colors.Add(color9);
                colors.Add(color10);

                Season season1 = new Season { Season_name = "Все сезоны" };
                Season season2 = new Season { Season_name = "Зима" };
                Season season3 = new Season { Season_name = "Весна/Осень" };
                Season season4 = new Season { Season_name = "Лето" };        

                seasons.Add(season1);
                seasons.Add(season2);
                seasons.Add(season3);
                seasons.Add(season4);

                SaveChanges();
            }
        }
        public DbSet<Clothes_style> clothes_styles { get; set; }
        public DbSet<Clothes_type> clothes_types { get; set; }
        public DbSet<Season> seasons { get; set; }
        public DbSet<Colors> colors { get; set; }
        public DbSet<Clothes_Item> clothes_items { get; set; }
        public DbSet<Outfit> outfits { get; set; }
        public DbSet<Album> albums { get; set; }

    }
}
