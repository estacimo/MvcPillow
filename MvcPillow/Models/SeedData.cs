using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcPillow.Data;
using System;
using System.Linq;

namespace MvcPillow.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcPillowContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcPillowContext>>()))
            {
                // Look for any movies.
                if (context.Pillow.Any())
                {
                    return;   // DB has been seeded
                }

                context.Pillow.AddRange(  // at least 10 different pillows to display
                    new Pillow
                    {
                        Image = "",
                        Size = "Standard",
                        Purpose = "Bed Pillow",
                        Density = "Soft",
                        Color = "White",
                        Shape = "Rectangular",
                        Material = "Memory Foam",
                        Price = 24.99M
                    },

                    new Pillow
                    {
                        Image = "",
                        Size = "Standard",
                        Purpose = "Neck Pillow",
                        Density = "Medium",
                        Color = "Yellow",
                        Shape = "Custom",
                        Material = "Memory Foam",
                        Price = 18.99M
                    },

                    new Pillow
                    {
                        Image = "",
                        Size = "Jumbo",
                        Purpose = "Bed Pillow",
                        Density = "Soft",
                        Color = "Blue",
                        Shape = "Rectangular",
                        Material = "Down",
                        Price = 14.99M
                    },

                    new Pillow
                    {
                        Image = "",
                        Size = "Queen",
                        Purpose = "Bed Pillow",
                        Density = "Firm",
                        Color = "Red",
                        Shape = "Rectangular",
                        Material = "Feathers",
                        Price = 21.99M
                    },

                    new Pillow
                    {
                        Image = "",
                        Size = "Standard",
                        Purpose = "Decorative Pillow",
                        Density = "Soft",
                        Color = "Green",
                        Shape = "Circular",
                        Material = "Wool",
                        Price = 13.99M
                    },

                    new Pillow
                    {
                        Image = "",
                        Size = "King",
                        Purpose = "Bed Pillow",
                        Density = "Medium",
                        Color = "Orange",
                        Shape = "Rectangular",
                        Material = "Wool",
                        Price = 34.99M
                    },

                    new Pillow
                    {
                        Image = "",
                        Size = "Standard",
                        Purpose = "Decorative Pillow",
                        Density = "Medium",
                        Color = "Custom",
                        Shape = "Square",
                        Material = "Wool",
                        Price = 6.99M
                    },

                    new Pillow
                    {
                        Image = "",
                        Size = "Jumbo",
                        Purpose = "Decorative Pillow",
                        Density = "Soft",
                        Color = "Pink",
                        Shape = "Custom",
                        Material = "Down",
                        Price = 4.99M
                    },

                    new Pillow
                    {
                        Image = "",
                        Size = "Queen",
                        Purpose = "Bed Pillow",
                        Density = "Soft",
                        Color = "Beige",
                        Shape = "Rectangular",
                        Material = "Latex",
                        Price = 24.99M
                    },
                    new Pillow
                    {
                        Image = "",
                        Size = "Standard",
                        Purpose = "Neck Pillow",
                        Density = "Medium",
                        Color = "Black",
                        Shape = "Custom",
                        Material = "Memory Foam",
                        Price = 12.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}