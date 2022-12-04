using Microsoft.EntityFrameworkCore.Migrations;
using System.Net;
using System.Numerics;
using System.Xml.Linq;
using System;
using xlabs_pubapp.Models;

#nullable disable

namespace xlabspubapp.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
            table: "Details",
            columns: new[] { "Id","Name", "Category", "Url", "Date", "Excerpt", "Thumbnail", "Lat", "Lng", "Address", "Phone", "Twitter", "StarsBeer", "StarsAtmosphere", "StarsAmnities", "StarsValue", "Tags" },
            values: new object[] {
                1,
                "Golf Cafe Bar",
                1,
                "http://leedsbeer.info/?p=1382",
                "2013-04-27T14:44:22+00:00",
                "FORE! You can play \"golf\" here and enjoy a nice bottled ale.",
                "http://leedsbeer.info/wp-content/uploads/2013/04/20130422_204442.jpg",
                "53.7934952",
                "-1.5478653",
                "1 Little Neville Street, Granary Wharf, Leeds LS1 4ED",
                "0113 244 4428",
                "GolfCafeBar",
                2.5,
                2.5,
                3.5,
                2.5,
                "beer garden,coffee,food,free wifi,sports"
            });

            migrationBuilder.InsertData(
            table: "Details",
            columns: new[] { "Id", "Name", "Category", "Url", "Date", "Excerpt", "Thumbnail", "Lat", "Lng", "Address", "Phone", "Twitter", "StarsBeer", "StarsAtmosphere", "StarsAmnities", "StarsValue", "Tags" },
            values: new object[] {
                2,
                "115 The Headrow",
                0,
                "http://leedsbeer.info/?p=2753",
                "2014-10-18T15:48:51+00:00",
                "A bar that lives up to its name.",
                "http://leedsbeer.info/wp-content/uploads/2014/10/115.jpg",
                "53.7994003",
                "-1.545981",
                "115 The Headrow, Leeds, LS1 5JW",
                "0113 244 4428",
                "BLoungeGrp",
                1.5,
                3,
                2.5,
                2,
                "coffee,food"
            });        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1
                );

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2
                );
        }
    }
}
