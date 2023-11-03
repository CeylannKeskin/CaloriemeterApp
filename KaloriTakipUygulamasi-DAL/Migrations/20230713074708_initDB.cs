using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaloriTakipUygulamasi_DAL.Migrations
{
    public partial class initDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    AccountID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(name: "First Name", type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(name: "Last Name", type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    BirthDate = table.Column<DateTime>(name: "Birth Date", type: "smalldatetime", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: true),
                    AccountType = table.Column<string>(name: "Account Type", type: "nvarchar(5)", maxLength: 5, nullable: false),
                    CreatedTime = table.Column<DateTime>(name: "Created Time", type: "smalldatetime", nullable: false),
                    UpdatedTime = table.Column<DateTime>(name: "Updated Time", type: "smalldatetime", nullable: false),
                    PassivedTime = table.Column<DateTime>(name: "Passived Time", type: "smalldatetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.AccountID);
                });

            migrationBuilder.CreateTable(
                name: "Food Categories",
                columns: table => new
                {
                    FoodCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(name: "Category Name", type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CategoryPicture = table.Column<string>(name: "Category Picture", type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Food Categories", x => x.FoodCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Repasts",
                columns: table => new
                {
                    RepastID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RepastName = table.Column<string>(name: "Repast Name", type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repasts", x => x.RepastID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    AccountID = table.Column<int>(type: "int", nullable: false),
                    DailyCalorie = table.Column<double>(name: "Daily Calorie", type: "float", nullable: true),
                    DailyFat = table.Column<double>(name: "Daily Fat", type: "float", nullable: true),
                    DailyCarbonhydrate = table.Column<double>(name: "Daily Carbonhydrate", type: "float", nullable: true),
                    DailyProtein = table.Column<double>(name: "Daily Protein", type: "float", nullable: true),
                    LimitOfCalories = table.Column<double>(name: "Limit Of Calories", type: "float", nullable: true),
                    LimitOfProtein = table.Column<double>(type: "float", nullable: true),
                    LimitOfCarbonhydrate = table.Column<double>(type: "float", nullable: true),
                    LimitOfFat = table.Column<double>(type: "float", nullable: true),
                    Height = table.Column<double>(type: "float", nullable: true),
                    Weight = table.Column<double>(type: "float", nullable: true),
                    UserBMI = table.Column<double>(name: "User BMI", type: "float", nullable: true),
                    BMIStatus = table.Column<string>(name: "BMI Status", type: "nvarchar(11)", maxLength: 11, nullable: true),
                    BMR = table.Column<double>(type: "float", nullable: true),
                    Repast = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.AccountID);
                    table.ForeignKey(
                        name: "FK_Users_Accounts_AccountID",
                        column: x => x.AccountID,
                        principalTable: "Accounts",
                        principalColumn: "AccountID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    FoodID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(name: "Food Name", type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FoodCategoryID = table.Column<int>(name: "Food Category ID", type: "int", nullable: true),
                    Calorie = table.Column<double>(type: "float", nullable: true),
                    Fat = table.Column<double>(type: "float", nullable: true),
                    Carbonhydrate = table.Column<double>(type: "float", nullable: true),
                    Protein = table.Column<double>(type: "float", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    FoodPicture = table.Column<string>(name: "Food Picture", type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Amount = table.Column<double>(type: "float", nullable: true),
                    Counter = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.FoodID);
                    table.ForeignKey(
                        name: "FK_Foods_Food Categories_Food Category ID",
                        column: x => x.FoodCategoryID,
                        principalTable: "Food Categories",
                        principalColumn: "FoodCategoryID");
                });

            migrationBuilder.CreateTable(
                name: "RepastUser",
                columns: table => new
                {
                    RepastsRepastID = table.Column<int>(type: "int", nullable: false),
                    UsersAccountID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepastUser", x => new { x.RepastsRepastID, x.UsersAccountID });
                    table.ForeignKey(
                        name: "FK_RepastUser_Repasts_RepastsRepastID",
                        column: x => x.RepastsRepastID,
                        principalTable: "Repasts",
                        principalColumn: "RepastID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RepastUser_Users_UsersAccountID",
                        column: x => x.UsersAccountID,
                        principalTable: "Users",
                        principalColumn: "AccountID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserFoods",
                columns: table => new
                {
                    UserFoodID = table.Column<int>(name: "User Food ID", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountID = table.Column<int>(name: "Account ID", type: "int", nullable: false),
                    FoodID = table.Column<int>(name: "Food ID", type: "int", nullable: false),
                    Calorie = table.Column<double>(type: "float", nullable: true),
                    Fat = table.Column<double>(type: "float", nullable: true),
                    Carbonhydrate = table.Column<double>(type: "float", nullable: true),
                    Protein = table.Column<double>(type: "float", nullable: true),
                    Amount = table.Column<double>(type: "float", nullable: true),
                    RepastID = table.Column<int>(name: "Repast ID", type: "int", nullable: true),
                    AddedTime = table.Column<DateTime>(name: "Added Time", type: "datetime", nullable: false),
                    UsersAccountID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFoods", x => x.UserFoodID);
                    table.ForeignKey(
                        name: "FK_UserFoods_Foods_Food ID",
                        column: x => x.FoodID,
                        principalTable: "Foods",
                        principalColumn: "FoodID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFoods_Repasts_Repast ID",
                        column: x => x.RepastID,
                        principalTable: "Repasts",
                        principalColumn: "RepastID");
                    table.ForeignKey(
                        name: "FK_UserFoods_Users_UsersAccountID",
                        column: x => x.UsersAccountID,
                        principalTable: "Users",
                        principalColumn: "AccountID");
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "AccountID", "Account Type", "Age", "Birth Date", "City", "Country", "Created Time", "Email", "First Name", "Gender", "Last Name", "Passived Time", "Password", "Updated Time" },
                values: new object[] { 1, "Admin", 32, new DateTime(2023, 7, 13, 10, 47, 8, 46, DateTimeKind.Local).AddTicks(9492), "İstanbul", "Türkiye", new DateTime(2023, 7, 13, 10, 47, 8, 46, DateTimeKind.Local).AddTicks(9493), "sametarsl@gmail.com", "Samet", true, "Arslan", null, "nG9E5OVTK0GbLkh38JIzZubiS1A=", new DateTime(2023, 7, 13, 10, 47, 8, 46, DateTimeKind.Local).AddTicks(9493) });

            migrationBuilder.InsertData(
                table: "Food Categories",
                columns: new[] { "FoodCategoryID", "Category Name", "Category Picture" },
                values: new object[,]
                {
                    { 1, "Meats", "../../../images/foodcategoryicons/meat.png" },
                    { 2, "Poultry", "../../../images/foodcategoryicons/poultry.png" },
                    { 3, "Vegetables and Legumes", "../../../images/foodcategoryicons/vegetable.png" },
                    { 4, "Grain Products", "../../../images/foodcategoryicons/grain.png" },
                    { 5, "Eggs", "../../../images/foodcategoryicons/egg.png" },
                    { 6, "Dairy Products", "../../../images/foodcategoryicons/dairy.png" },
                    { 7, "Fruits", "../../../images/foodcategoryicons/fruit.png" },
                    { 8, "Soups", "../../../images/foodcategoryicons/soups.png" },
                    { 9, "Main Dishes", "../../../images/foodcategoryicons/MainDishes.png" },
                    { 10, "Complementary Meals", "../../../images/foodcategoryicons/ComplementaryMeals.png" },
                    { 11, "Salads", "../../../images/foodcategoryicons/Salads.png" },
                    { 12, "Desserts", "../../../images/foodcategoryicons/Desserts.png" }
                });

            migrationBuilder.InsertData(
                table: "Repasts",
                columns: new[] { "RepastID", "Repast Name" },
                values: new object[,]
                {
                    { 1, "Breakfast" },
                    { 2, "Lunch" },
                    { 3, "Dinner" },
                    { 4, "Snack" }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodID", "Amount", "Calorie", "Carbonhydrate", "Counter", "Description", "Fat", "Food Category ID", "Food Name", "Food Picture", "Protein" },
                values: new object[,]
                {
                    { 1, 100.0, 120.0, 0.0, 0, "Beef, in general, refers to the meat of young cattle or calves. Beef is obtained from the muscle tissue of cows or calves and is commonly known for being nutritious, flavorful, and versatile in cooking. It contains high amounts of protein, iron, zinc, and B vitamins. Beef can be consumed by grilling, used in meat dishes, making meatballs, or incorporated into various recipes. It is a popular choice among red meats and is widely consumed in various cultures.", 3.6000000000000001, 1, "Ground Baby Beef (Half Fat)", "../../../images/foodimages/danakıyma.jfif", 21.0 },
                    { 2, 100.0, 170.0, 0.0, 0, "Beef, in general, refers to the meat of young cattle or calves. Beef is obtained from the muscle tissue of cows or calves and is commonly known for being nutritious, flavorful, and versatile in cooking. It contains high amounts of protein, iron, zinc, and B vitamins. Beef can be consumed by grilling, used in meat dishes, making meatballs, or incorporated into various recipes. It is a popular choice among red meats and is widely consumed in various cultures.", 8.1999999999999993, 1, "Ground Baby Beef (Fatty)", "../../../images/foodimages/danakıyma.jfif", 20.0 },
                    { 3, 100.0, 103.0, 0.0, 0, "Beef, in general, refers to the meat of young cattle or calves. Beef is obtained from the muscle tissue of cows or calves and is commonly known for being nutritious, flavorful, and versatile in cooking. It contains high amounts of protein, iron, zinc, and B vitamins. Beef can be consumed by grilling, used in meat dishes, making meatballs, or incorporated into various recipes. It is a popular choice among red meats and is widely consumed in various cultures.", 1.0, 1, "Calf Thigh", "../../../images/foodimages/danabut.jfif", 20.0 },
                    { 4, 100.0, 200.0, 0.0, 0, "Sheep meat, also known as mutton, is a meat product obtained from sheep. It is considered a nutritious source due to its high protein, vitamin, and mineral content. It is cooked and consumed in various ways across different cultures, playing a significant role in local cuisines. However, health factors, cooking methods, and individual dietary preferences should be taken into consideration.", 13.0, 1, "Ground Mutton (Fatless)", "../../../images/foodimages/KoyunKıyma.jfif", 19.0 },
                    { 5, 100.0, 223.0, 0.0, 0, "Sheep meat, also known as mutton, is a meat product obtained from sheep. It is considered a nutritious source due to its high protein, vitamin, and mineral content. It is cooked and consumed in various ways across different cultures, playing a significant role in local cuisines. However, health factors, cooking methods, and individual dietary preferences should be taken into consideration.", 16.0, 1, "Ground Mutton (Half Fat)", "../../../images/foodimages/KoyunKıyma.jfif", 18.0 },
                    { 6, 100.0, 430.0, 0.0, 0, "Sheep meat, also known as mutton, is a meat product obtained from sheep. It is considered a nutritious source due to its high protein, vitamin, and mineral content. It is cooked and consumed in various ways across different cultures, playing a significant role in local cuisines. However, health factors, cooking methods, and individual dietary preferences should be taken into consideration.", 38.0, 1, "Ground Mutton (Fatty)", "../../../images/foodimages/KoyunKıyma.jfif", 18.0 },
                    { 7, 100.0, 250.0, 0.0, 0, "Sheep meat, also known as mutton, is a meat product obtained from sheep. It is considered a nutritious source due to its high protein, vitamin, and mineral content. It is cooked and consumed in various ways across different cultures, playing a significant role in local cuisines. However, health factors, cooking methods, and individual dietary preferences should be taken into consideration.", 18.0, 1, "Sheep Thigh", "../../../images/foodimages/koyunbut.jfif", 18.0 },
                    { 8, 100.0, 283.0, 0.0, 0, "Beef is a meat product obtained from cattle. It is known as a nutritious source due to its high protein content and is used in various dishes.", 21.0, 1, "Ground Beef(cattle) (Half Fat)", "../../../images/foodimages/sıgırkıyma.jfif", 21.0 },
                    { 9, 100.0, 345.0, 0.0, 0, "Beef is a meat product obtained from cattle. It is known as a nutritious source due to its high protein content and is used in various dishes.", 29.0, 1, "Ground Beef (cattle) (Fatty)", "../../../images/foodimages/sıgırkıyma.jfif", 17.0 },
                    { 10, 100.0, 200.0, 0.0, 0, "Beef is a meat product obtained from cattle. It is known as a nutritious source due to its high protein content and is used in various dishes.", 13.0, 1, "Edgebone", "../../../images/foodimages/sıgırbutu.jfif", 19.0 },
                    { 11, 100.0, 160.0, 4.0, 0, "Turkey meat is a meat product obtained from turkeys. It is known for its low fat content and is a flavorful source of protein.", 8.0, 2, "Turkey", "../../../images/foodimages/hindi.jfif", 20.0 },
                    { 12, 100.0, 122.0, 0.0, 0, "Chicken thigh is a rich source of protein, vitamins, and minerals. It is considered a good protein source, providing essential amino acids for the body. It also contains important minerals like iron, zinc, B vitamins, and phosphorus. However, the exact nutritional values may vary depending on factors such as cooking method, size, and other variables.", 3.0, 2, "Chicken Drumstick", "../../../images/foodimages/tavukbut.jfif", 21.0 },
                    { 13, 100.0, 147.0, 1.0, 0, "Chicken liver is a nutrient-rich food source, high in protein, iron, B vitamins, and vitamin A.", 5.0, 2, "Chicken Livers", "../../../images/foodimages/tavulciger.jfif", 22.0 },
                    { 14, 100.0, 104.0, 0.0, 0, "Chicken breast is a food source that is high in protein and B vitamins, while being low in fat.", 1.0, 2, "Chicken Breast", "../../../images/foodimages/tavulgögus.jfif", 23.0 },
                    { 15, 100.0, 354.0, 53.700000000000003, 0, "Dried broad beans are a plant-based source of protein and fiber. They also contain carbohydrates, vitamins, and minerals.", 1.7, 3, "Dried Broad Beans", "../../../images/foodimages/kurubakla.jfif", 25.0 },
                    { 16, 100.0, 72.0, 9.8000000000000007, 0, "Broad beans are a nutritious vegetable, rich in protein, fiber, vitamins, and minerals. They strengthen the immune system, support digestion, and provide energy.", 0.40000000000000002, 3, "Broad Beans", "../../../images/foodimages/tazebakla.jfif", 5.7000000000000002 },
                    { 17, 100.0, 42.0, 4.0, 0, "Fresh okra is a low-calorie vegetable that is rich in fiber, vitamins, and minerals. Its high fiber content supports digestive health and provides a feeling of fullness. It also contains important nutrients such as vitamin C, vitamin K, iron, and folate. Fresh okra strengthens the immune system, promotes blood health, and can be preferred as part of a healthy diet.", 0.10000000000000001, 3, "Okra", "../../../images/foodimages/bamya.jfif", 6.0 },
                    { 18, 100.0, 346.0, 57.0, 0, "Dried kidney beans are a nutritious legume that is high in protein, fiber, vitamins, and minerals. Protein supports muscle development and repair, while fiber aids in digestion and provides a feeling of fullness. It also contains important nutrients such as iron, potassium, folate, and B vitamins. Dried kidney beans provide energy, support blood health, and can be preferred as part of a healthy diet.", 1.5, 3, "Dried Kidney Beans", "../../../images/foodimages/barbunya.jfif", 21.0 },
                    { 19, 100.0, 47.0, 8.6999999999999993, 0, "Fresh green peas are a highly nutritious vegetable that is packed with vitamins, minerals, fiber, and antioxidants. They are a rich source of vitamin C, vitamin K, vitamin B6, folate, and iron. Green peas also provide dietary fiber, which aids in digestion and helps maintain a healthy weight. They are low in calories and contain plant-based protein. Additionally, green peas offer numerous health benefits, including supporting heart health, boosting the immune system, and promoting eye health.", 0.20000000000000001, 3, "Fresh Peas", "../../../images/foodimages/tazebezelye.jfif", 2.2000000000000002 },
                    { 20, 100.0, 25.0, 5.7000000000000002, 0, "Green bell pepper is a low-calorie vegetable that is rich in vitamins C, A, fiber, and antioxidants. It also contains important nutrients such as B vitamins, potassium, and iron. Green bell pepper supports the immune system, improves digestive health, and preserves eye health. Additionally, it may assist with weight management and contribute to overall well-being.", 0.20000000000000001, 3, "Green Pepper", "../../../images/foodimages/yeşilbiber.jfif", 1.2 },
                    { 21, 100.0, 47.0, 8.9000000000000004, 0, "Brussels sprouts are a low-calorie vegetable that is high in fiber, vitamin C, vitamin K, and folate. It also contains important minerals such as potassium, iron, and magnesium. Brussels sprouts support the immune system, improve digestive health, and maintain bone health. They are also known for their antioxidant properties and overall health benefits.", 0.5, 3, "Brussels Sprouts", "../../../images/foodimages/bruksellahana.jfif", 4.4000000000000004 },
                    { 22, 100.0, 25.0, 1.0, 0, "Tomato is a low-calorie fruit that is rich in vitamins C, A, potassium, and antioxidants such as lycopene. It also supports digestion with its fiber content. Tomato helps maintain heart health, supports eye health, and strengthens the immune system. Additionally, it may have protective effects against cancer.", 0.29999999999999999, 3, "Tomato", "../../../images/foodimages/domates.jfif", 1.0 },
                    { 23, 100.0, 63.0, 11.9, 0, "Artichoke is a low-calorie vegetable that is high in fiber, vitamin C, folate, and potassium. It also contains antioxidants and flavonoids. Artichoke supports digestive health, helps lower cholesterol levels, boosts the immune system, and promotes liver health. Additionally, it may assist in blood sugar control and has anti-inflammatory effects.", 0.40000000000000002, 3, "Artichoke", "../../../images/foodimages/enginar.jfif", 2.8999999999999999 },
                    { 24, 100.0, 333.0, 1.3, 0, "Dried kidney beans are a nutritious legume that is high in protein, fiber, vitamins, and minerals. Protein supports muscle development and repair, while fiber aids in digestion and provides a feeling of fullness. It also contains important nutrients such as iron, magnesium, potassium, and B vitamins. Dried kidney beans provide energy, support blood health, and can be preferred as part of a healthy diet.", 61.600000000000001, 3, "Dried Beans", "../../../images/foodimages/kurufasulye.jfif", 20.699999999999999 },
                    { 25, 100.0, 35.0, 0.20000000000000001, 0, "Fresh green beans are a highly nutritious vegetable that is low in calories and rich in fiber. They are a great source of vitamins A, C, and K, as well as folate and manganese. Green beans also provide essential minerals like potassium and iron. They promote digestion, support heart health, and contribute to maintaining strong bones. Additionally, they are packed with antioxidants and offer numerous health benefits, including immune system support and overall well-being.", 7.7000000000000002, 3, "Beans", "../../../images/foodimages/tazefasulye.jfif", 2.3999999999999999 },
                    { 26, 100.0, 42.0, 9.3000000000000007, 0, "Carrot is a nutritious vegetable that is high in vitamin A, fiber, and antioxidants. It also contains important nutrients such as vitamin C, vitamin K, potassium, and iron. Carrot supports eye health, strengthens the immune system, and improves digestion. Additionally, it promotes skin health and is heart-friendly.", 0.29999999999999999, 3, "Carrot", "../../../images/foodimages/havuc.jfif", 1.2 },
                    { 27, 100.0, 8.0, 1.0, 0, "Cucumber is a low-calorie vegetable that is high in water content and rich in fiber. It contains important nutrients such as vitamin A, vitamin C, vitamin K, and potassium. Cucumber supports hydration, improves digestive health, and promotes skin health. It also adds freshness and flavor to many dishes and salads.", 0.0, 3, "Cucumber", "../../../images/foodimages/salatalık.jfif", 1.0 },
                    { 28, 100.0, 25.0, 3.2000000000000002, 0, "Spinach is a low-calorie leafy vegetable that is rich in various nutrients. It contains iron, calcium, vitamin A, vitamin C, fiber, and antioxidants. Spinach supports bone health, preserves eye health, boosts the immune system, and aids in digestion. Additionally, it may help regulate blood pressure and possess anti-aging properties.", 0.29999999999999999, 3, "Spinach", "../../../images/foodimages/ıspanak.jfif", 2.2999999999999998 },
                    { 29, 100.0, 19.0, 3.8999999999999999, 0, "Zucchini, a low-calorie vegetable, is rich in fiber, vitamin C, vitamin A, and potassium. Its fiber content supports digestive health, while vitamin C strengthens the immune system. Vitamin A contributes to eye health, and potassium supports healthy blood pressure levels. Zucchini can be preferred as part of a healthy diet and can be used in various dishes.", 0.10000000000000001, 3, "Zucchini", "../../../images/foodimages/kabak.jfif", 0.59999999999999998 },
                    { 30, 100.0, 25.0, 4.9000000000000004, 0, "Cauliflower is a vegetable that belongs to the brassica family and provides a nutritious profile. Its essential nutritional values include fiber, vitamin C, folate, vitamin K, vitamin B6, potassium, and magnesium. Additionally, cauliflower is a low-calorie vegetable with low carbohydrate and fat content. Its high fiber content supports digestive health, and its richness in antioxidants is beneficial for the body. Cauliflower is known as a vegetable that can contribute to a healthy diet.", 0.20000000000000001, 3, "Cauliflower", "../../../images/foodimages/karnabahar.jfif", 2.3999999999999999 },
                    { 31, 100.0, 38.0, 7.0, 0, "Celery is a root vegetable. Its nutritional values include vitamins C, K, B6, potassium, calcium, fiber, and antioxidants. It is a healthy, low-calorie vegetable that aids digestion.", 0.0, 3, "Celery", "../../../images/foodimages/kereviz.jfif", 2.0 },
                    { 32, 100.0, 42.0, 9.5999999999999996, 0, "Red beetroot is a root vegetable that is commonly used in salads. It is rich in fiber, vitamin C, iron, and folate. It also contains important minerals such as potassium, manganese, magnesium, and B vitamins. Red beetroot is a low-calorie food that aids digestion and supports digestive health. It is also known for its antioxidant properties, which boost the immune system and prevent cell damage.", 0.10000000000000001, 3, "Red Beet", "../../../images/foodimages/kırmızıpancar.jfif", 1.6000000000000001 },
                    { 33, 100.0, 24.0, 5.2999999999999998, 0, "Cabbage is a leafy green vegetable that provides a nutritious profile. It contains nutrients such as vitamin C, vitamin K, fiber, folate, iron, and calcium. It is also rich in antioxidants and phytochemicals. Cabbage supports digestion, boosts the immune system, and helps reduce the risk of cancer.", 0.20000000000000001, 3, "Cabbage", "../../../images/foodimages/lahana.jfif", 1.3999999999999999 },
                    { 34, 100.0, 16.0, 0.40000000000000002, 0, "Mushrooms are low in calories and fat, but rich in protein, fiber, vitamins, and minerals. They can aid in weight management, boost the immune system, and support digestive health. However, caution is needed as some mushrooms can be toxic. Consult a healthcare professional if you have any health concerns or allergies related to mushrooms.", 0.29999999999999999, 3, "Mushroom", "../../../images/foodimages/mantar.jfif", 2.3999999999999999 },
                    { 35, 100.0, 15.0, 2.8999999999999999, 0, "Lettuce, in short with its nutritional values, is a leafy vegetable that is low in calories and high in water and fiber content. It also contains vitamins A, C, and K, as well as minerals like folate, iron, and potassium. Lettuce is commonly used in salads and sandwiches and can be an important part of a healthy eating plan.", 0.20000000000000001, 3, "Lettuce", "../../../images/foodimages/marul.jfif", 1.2 },
                    { 36, 100.0, 351.0, 57.399999999999999, 0, "Kuru mercimek (lentils) is a nutritious legume that contains protein, fiber, vitamins, and minerals. It is rich in protein and fiber, providing energy to the body and supporting the digestive system. Additionally, it contains important nutrients such as iron, folate, potassium, and B vitamins. Kuru mercimek can be preferred as part of a healthy diet and can be used in various dishes.", 1.3, 3, "Lentils", "../../../images/foodimages/mercimek kuru.jfif", 23.699999999999999 },
                    { 37, 100.0, 376.0, 56.700000000000003, 0, "Chickpeas, also known as garbanzo bean, is a legume that is highly nutritious. It contains important nutrients such as protein, fiber, iron, magnesium, phosphorus, B vitamins, and folate. Chickpeas help regulate digestion, lower cholesterol levels, provide energy, support muscle development, and strengthen the immune system. They may also be beneficial for maintaining a healthy weight.", 6.2000000000000002, 3, "Chickpeas", "../../../images/foodimages/nohut.jfif", 19.199999999999999 },
                    { 38, 100.0, 42.0, 9.5999999999999996, 0, "Beets are a low-calorie root vegetable that provides numerous nutritional benefits. They are high in fiber, vitamins (C, B6, and folate), and minerals (potassium). Additionally, beets are a rich source of antioxidants, which help reduce cell damage by combating free radicals. As a result, incorporating beets into a healthy diet can support digestive health, boost the immune system, and improve cardiovascular health.", 0.10000000000000001, 3, "Beet", "../../../images/foodimages/pancar.jfif", 1.6000000000000001 },
                    { 39, 100.0, 83.0, 19.100000000000001, 0, "Potato is a root vegetable that is rich in starch. It also contains several essential nutrients. Potatoes are high in carbohydrates, proteins, fiber, vitamins (such as vitamin C and vitamin B6), and minerals (such as potassium and manganese). They are also low in fat. Potatoes provide energy, support the digestive system, and strengthen the immune system.", 0.10000000000000001, 3, "Potato", "../../../images/foodimages/patates.jfif", 2.0 },
                    { 40, 100.0, 24.0, 5.5, 0, "Eggplant is a low-calorie vegetable that contains carbohydrates, fiber, vitamins, and minerals. It also contains antioxidants.", 0.20000000000000001, 3, "Eggplant", "../../../images/foodimages/patlıcan.jfif", 1.1000000000000001 },
                    { 41, 100.0, 27.0, 4.7999999999999998, 0, "Chard is a nutritious leafy vegetable. It contains high amounts of fiber, iron, calcium, and vitamins A and K.", 0.40000000000000002, 3, "Chard", "../../../images/foodimages/pazı.jfif", 2.6000000000000001 },
                    { 42, 100.0, 52.0, 1.8, 0, "Leek is a nutritious vegetable. It contains nutrients such as fiber, vitamin C, vitamin K, folate, and potassium.", 0.20000000000000001, 3, "Leek", "../../../images/foodimages/pırasa.jfif", 1.8 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodID", "Amount", "Calorie", "Carbonhydrate", "Counter", "Description", "Fat", "Food Category ID", "Food Name", "Food Picture", "Protein" },
                values: new object[,]
                {
                    { 43, 100.0, 32.0, 3.7999999999999998, 0, "Purslane is a green leafy vegetable that is commonly used in salads. It is a low-calorie food and contains rich amounts of vitamins, minerals, and fiber. Purslane is particularly high in vitamins A, C, K, and minerals such as iron, calcium, and magnesium. It also contains antioxidants and can support the immune system. Purslane can help regulate the digestive system, promote digestive health, and be beneficial in weight loss processes.", 0.40000000000000002, 3, "Purslane", "../../../images/foodimages/semizotu.jfif", 2.0 },
                    { 44, 100.0, 247.0, 53.100000000000001, 0, "Wheat bread is a type of bread made from wheat flour, water, yeast, and salt, among other basic ingredients. Wheat bread contains various nutrients such as carbohydrates, protein, fiber, vitamins, and minerals. However, the nutritional values may vary depending on the bread-making process, the type of flour used, and other additional ingredients. Generally, wheat bread is a healthy source of energy and is a staple in many diets.", 1.1000000000000001, 4, "Wheat Bread", "../../../images/foodimages/bugdayekmegı.jfif", 7.2000000000000002 },
                    { 45, 100.0, 350.0, 69.799999999999997, 0, "Bulgur, a grain obtained by grinding and cleaning wheat, is a food with high nutritional value. It contains complex carbohydrates, fiber, protein, vitamins, and minerals. Bulgur's fibrous structure slows down digestion and provides a feeling of satiety. It can also help regulate calorie intake due to its low fat content. With its iron, magnesium, phosphorus, B vitamins, and folate, Bulgur provides important support for the body. Moreover, Bulgur is a preferred food in a healthy diet due to its low glycemic index value.", 1.5, 4, "Bulgur Wheat", "../../../images/foodimages/bulgur.jfif", 12.5 },
                    { 46, 100.0, 390.0, 76.0, 0, "Erişte, commonly known as 'noodles' in English, is a type of pasta typically made from flour, eggs, and water. Its nutritional values vary depending on the ingredients used and the specific recipe. Generally, erişte is a carbohydrate-rich pasta and can be a source of protein, vitamins, and minerals. In summary, erişte is a type of pasta high in carbohydrates and may contain protein, vitamins, and minerals.", 5.0, 4, "Noodle", "../../../images/foodimages/erişte.jfif", 7.7000000000000002 },
                    { 47, 100.0, 390.0, 76.0, 0, "Pasta, commonly served in various shapes, is a light and filling food. Carbohydrates provide energy to the body, and pasta meets this need. Protein content contributes to muscle strength and recovery. Fiber supports the digestive system and provides a feeling of fullness. B vitamins are important for metabolism and can be found in pasta. Additionally, there can be variations in mineral content among different types of pasta.", 5.0, 4, "Pasta", "../../../images/foodimages/makarna.jfif", 7.7000000000000002 },
                    { 48, 100.0, 351.0, 72.0, 0, "Corn is a high-carbohydrate grain that contains fiber, vitamins A and C, folate, magnesium, and potassium.", 2.2000000000000002, 4, "Corn", "../../../images/foodimages/mısır.jfif", 9.4000000000000004 },
                    { 49, 100.0, 353.0, 74.0, 0, "Corn flour is a type of flour obtained by grinding corn. It contains high amounts of carbohydrates and dietary fiber. Carbohydrates are used as an energy source, while fiber helps regulate the digestive system.", 1.3999999999999999, 4, "Cornflour", "../../../images/foodimages/mısır unu.jfif", 9.0 },
                    { 50, 100.0, 353.0, 74.0, 0, "Starch is a type of carbohydrate found in plants. It is a significant source of energy for humans and is converted into glucose during digestion. Starch is commonly found in grains (such as wheat, rice, and corn), potatoes, corn, and some legumes. Its nutritional value typically includes the amount of carbohydrates it contains, providing energy. Other nutrients such as protein, fat, vitamins, and minerals are present in lower quantities in starch.", 1.0, 4, "Starch", "../../../images/foodimages/nişasta.jfif", 10.0 },
                    { 51, 100.0, 368.0, 39.5, 0, "Pilav, rice or other grains cooked with water, is a dish obtained by boiling them. Its nutritional values may vary depending on the type of rice, cooking method, and other ingredients used. Generally, pilaf contains carbohydrates, proteins, fibers, and some minerals. However, the nutritional content of pilaf can vary based on the ingredients used and serving size.", 21.0, 4, "Rice", "../../../images/foodimages/pilav.jfif", 3.5 },
                    { 52, 100.0, 353.0, 74.0, 0, "Rice Flour is a type of flour obtained by grinding rice grains. It contains carbohydrates, protein, fiber, and various minerals. It provides energy, serves as building blocks for the body, regulates the digestive system, and contains important minerals. It is commonly used in various recipes.", 1.0, 4, "Rice Flour", "../../../images/foodimages/pirinçubu.jfif", 10.0 },
                    { 53, 100.0, 390.0, 76.0, 0, "Tel Şehriye is a type of thin and long noodle in Middle Eastern cuisine. It is used in dishes such as pilaf, soup, salad, and dessert. It is a quick, convenient, and flavorful option.", 5.0, 4, "Vermicelli", "../../../images/foodimages/tel şehriye.jfif", 7.7000000000000002 },
                    { 54, 100.0, 329.0, 58.799999999999997, 0, "Tarhanyi is a traditional Central Asian dish. This dish is made by processing the grains of a plant called 'Tarhun' which is typically composed of wheat and chickpeas. Tarhanyi is a nutrient-rich food in terms of basic nutritional values. It is a good source of protein, fiber, iron, and B vitamins. It is also a healthy option due to its low fat and cholesterol content.", 3.8999999999999999, 4, "Tarhana", "../../../images/foodimages/tarhana.jfif", 14.1 },
                    { 55, 100.0, 402.0, 66.0, 0, "Oat flour is a type of flour made by grinding oats. It is known for its high fiber content, low glycemic index, and rich nutrient profile. Oat flour is rich in complex carbohydrates, protein, fiber, vitamins (especially B vitamins), and minerals (such as manganese, phosphorus, magnesium, and zinc). Additionally, oat flour contains a type of soluble fiber called beta-glucan, which provides digestive health benefits. Oat flour can be used as part of a healthy diet and can contribute to nutrition in various recipes.", 7.0, 4, "Oat Flour", "../../../images/foodimages/yulafunu.jfif", 14.0 },
                    { 56, 100.0, 155.09999999999999, 0.0, 0, "Egg is a nutritious food that contains high levels of protein, healthy fats, vitamins (A, D, E, K, B2, B6, B12, folate), and minerals (iron, zinc, selenium, phosphorus). It also contains antioxidants that support eye health.", 6.0, 5, "Whole Egg", "../../../images/foodimages/yumurta.jfif", 8.0 },
                    { 57, 100.0, 377.0, 0.0, 0, "Egg yolk: It contains high protein, healthy fats, vitamins (A, D, E, K, B), and minerals (iron, selenium, zinc, phosphorus).", 33.0, 5, "Egg Yolk", "../../../images/foodimages/yumurtasarısı.jfif", 17.0 },
                    { 58, 100.0, 49.0, 1.0, 0, "Egg white is a low-calorie and fat-free source of protein. It contains essential amino acids, B vitamins, and minerals. It is cholesterol-free and important for muscle development, repair, and tissue regeneration.", 33.0, 5, "Egg Whites", "../../../images/foodimages/yumurtaakı.jfif", 11.0 },
                    { 59, 100.0, 70.0, 6.9000000000000004, 0, "Breast milk is the most suitable and nutritious source of food for a baby's healthy growth and development. It contains all the necessary nutrients for the baby and is easily digested. Additionally, breast milk contains special components such as antibodies that strengthen the immune system, enzymes that aid digestion, and omega-3 fatty acids that support brain development. Furthermore, breast milk helps mature the baby's digestive system and promotes a healthy gut flora. The nutritional composition of breast milk may vary depending on the baby's growth stage.", 4.4000000000000004, 6, "Breast Milk", "../../../images/foodimages/annesütü.jfif", 1.0 },
                    { 60, 100.0, 289.0, 2.1000000000000001, 0, "Feta cheese is a type of white cheese that is typically made from milk. It is rich in nutritional value and contains several important nutrients. Feta cheese is generally high in protein, calcium, phosphorus, sodium, potassium, and B vitamins. It also has low fat and carbohydrate content. In summary, feta cheese is a cheese type that is rich in protein, calcium, and other essential nutrients.", 21.600000000000001, 6, "Feta Cheese (Full Fat)", "../../../images/foodimages/beyaz peynir.jfif", 22.5 },
                    { 61, 100.0, 99.0, 3.7999999999999998, 0, "Feta cheese is a type of white cheese that is typically made from milk. It is rich in nutritional value and contains several important nutrients. Feta cheese is generally high in protein, calcium, phosphorus, sodium, potassium, and B vitamins. It also has low fat and carbohydrate content. In summary, feta cheese is a cheese type that is rich in protein, calcium, and other essential nutrients.", 0.69999999999999996, 6, "Feta Cheese (Low Fat)", "../../../images/foodimages/beyaz peynir.jfif", 19.0 },
                    { 62, 100.0, 61.0, 4.7000000000000002, 0, "Cow's milk is a nutrient-rich food that contains high-quality protein, a carbohydrate called lactose, fats, vitamins such as A, D, E, K, and minerals like calcium and phosphorus. Proteins are essential building blocks for the body, carbohydrates provide energy, and fats aid in the absorption of vitamins. The vitamins and minerals in cow's milk are necessary for eye health, bone development, nerve transmission, and other metabolic processes.", 3.2999999999999998, 6, "Milk (Fat)", "../../../images/foodimages/ineksütü.jfif", 3.2999999999999998 },
                    { 63, 100.0, 50.0, 4.7999999999999998, 0, "Cow's milk is a nutrient-rich food that contains high-quality protein, a carbohydrate called lactose, fats, vitamins such as A, D, E, K, and minerals like calcium and phosphorus. Proteins are essential building blocks for the body, carbohydrates provide energy, and fats aid in the absorption of vitamins. The vitamins and minerals in cow's milk are necessary for eye health, bone development, nerve transmission, and other metabolic processes.", 1.8999999999999999, 6, "Milk (Semi-skimmed)", "../../../images/foodimages/ineksütü.jfif", 3.2999999999999998 },
                    { 64, 100.0, 35.0, 4.9000000000000004, 0, "Cow's milk is a nutrient-rich food that contains high-quality protein, a carbohydrate called lactose, fats, vitamins such as A, D, E, K, and minerals like calcium and phosphorus. Proteins are essential building blocks for the body, carbohydrates provide energy, and fats aid in the absorption of vitamins. The vitamins and minerals in cow's milk are necessary for eye health, bone development, nerve transmission, and other metabolic processes.", 0.20000000000000001, 6, "Milk (Skim)", "../../../images/foodimages/ineksütü.jfif", 3.3999999999999999 },
                    { 65, 100.0, 349.0, 1.3999999999999999, 0, "Kashar cheese is a type of cheese typically made from cow's milk. It is a rich source of nutrients. It contains protein, fat, calcium, phosphorus, sodium, potassium, vitamin B, and vitamin A. However, Kashar cheese is a high-calorie food and should be consumed in moderation due to its saturated fat content. The nutritional values may vary depending on the production process, brand, and other factors.", 31.699999999999999, 6, "Cheese", "../../../images/foodimages/kaşarpeynir.jfif", 27.0 },
                    { 66, 100.0, 302.0, 3.0, 0, "Clotted cream is a dairy product with a high fat content that rises to the surface of milk and is collected. It is a rich source of nutrients and is typically a high-calorie food. Clotted cream contains fat, protein, calcium, phosphorus, and vitamins A and D. However, excessive consumption can lead to weight gain and increased cholesterol levels, so it is recommended to consume it in moderation.", 30.0, 6, "Cream %30", "../../../images/foodimages/kaymak.jfif", 2.0 },
                    { 67, 100.0, 69.0, 4.5, 0, "Goat milk is a nutritious liquid that contains protein, fat, carbohydrates, vitamins, and minerals. Its protein content helps with the development of muscles and tissues, while fat plays a role in providing energy. Goat milk also contains important nutrients such as vitamin A, calcium, phosphorus, and riboflavin. However, individual nutritional needs vary, so it should be consumed considering personal health conditions and tolerances.", 4.0999999999999996, 6, "Goat's Milk", "../../../images/foodimages/kecisütü.jfif", 3.6000000000000001 },
                    { 68, 100.0, 108.0, 5.4000000000000004, 0, "Sheep milk is a food that contains essential nutrients such as protein, fat, and carbohydrates. Proteins are important for the growth and repair of the body, fats provide energy and assist in the absorption of fat-soluble vitamins, while carbohydrates serve as a source of energy. In addition to these nutrients, sheep milk also contains other minerals and vitamins.", 7.0, 6, "Ewe Milk", "../../../images/foodimages/koyunsütü.jfif", 6.0 },
                    { 69, 100.0, 204.0, 3.7000000000000002, 0, "Cream is a dense and sweet dairy product with a high fat content. Its nutritional values can be summarized as follows: calories (typically 300-400 calories/100g), fat (30-40%), protein (low amount), and carbohydrates (low amount). It is important to consume cream in moderation.", 20.0, 6, "Cream %20", "../../../images/foodimages/krema.jfif", 2.8999999999999999 },
                    { 70, 100.0, 97.0, 5.2000000000000002, 0, "Manda milk is a nutritious type of milk with high protein, fat, lactose, vitamins, and minerals content. Its high protein content is important for growth and development, fats provide energy, and vitamins and minerals contribute to regulating bodily functions.", 6.9000000000000004, 6, "Water Buffalo", "../../../images/foodimages/mandasütü.jfif", 3.7999999999999998 },
                    { 71, 100.0, 61.0, 4.7000000000000002, 0, "Yogurt: Fermented dairy product. It contains high levels of protein, calcium, vitamins, and probiotics. It is beneficial for a healthy diet, bone health, digestion, and immune system.", 3.2999999999999998, 6, "Yoghurt (Full Fat)", "../../../images/foodimages/yogurt.jfif", 3.5 },
                    { 72, 100.0, 63.0, 7.0, 0, "Yogurt: Fermented dairy product. It contains high levels of protein, calcium, vitamins, and probiotics. It is beneficial for a healthy diet, bone health, digestion, and immune system.", 1.6000000000000001, 6, "Yoghurt (Half Fat)", "../../../images/foodimages/yogurt.jfif", 5.2999999999999998 },
                    { 73, 100.0, 56.0, 7.7000000000000002, 0, "Yogurt: Fermented dairy product. It contains high levels of protein, calcium, vitamins, and probiotics. It is beneficial for a healthy diet, bone health, digestion, and immune system.", 0.20000000000000001, 6, "Yoghurt (Fatless)", "../../../images/foodimages/yogurt.jfif", 5.7000000000000002 },
                    { 74, 100.0, 57.0, 13.0, 0, "Pear is a highly nutritious fruit. It is a rich source of dietary fiber, vitamins (especially vitamin C), and minerals that are important for the body's energy needs. Pear also contains antioxidants and supports the digestive system, improving gut health. In summary, pear is a valuable option for a healthy diet.", 0.0, 7, "Pear", "../../../images/foodimages/armut.jfif", 1.0 },
                    { 75, 100.0, 39.0, 8.0, 0, "Strawberries are low-calorie fruits that contain various nutrients. They are rich in vitamin C, fiber, folate, potassium, and antioxidants. Vitamin C supports the immune system, while antioxidants protect cells from free radicals. Fiber improves digestion and provides a feeling of fullness. Folate is important for cell renewal and DNA synthesis. Potassium helps regulate muscle functions and blood pressure.", 0.0, 7, "Strawberry", "../../../images/foodimages/çilek.jfif", 1.0 },
                    { 76, 100.0, 52.0, 12.0, 0, "An apple is a nutritious fruit that is typically round or flat in shape. Its skin is usually shiny red, green, or yellow in color. The inside of an apple is juicy and sweet. In terms of nutritional value, an apple is a low-calorie fruit and is rich in fiber, vitamin C, potassium, and antioxidants. Its fiber content supports digestive health and provides a feeling of fullness. Vitamin C strengthens the immune system, and antioxidants protect the body against the harmful effects of free radicals.", 0.0, 7, "Apple", "../../../images/foodimages/elma.jfif", 0.0 },
                    { 77, 100.0, 65.0, 18.0, 0, "Plum is a fruit belonging to the Prunus genus. It contains nutrients such as water, fiber, vitamin C, vitamin A, potassium, and iron. It also contains phenolic compounds that have antioxidant properties and other health benefits.", 0.20000000000000001, 7, "Plum", "../../../images/foodimages/erik.jfif", 5.0 },
                    { 78, 100.0, 65.0, 20.399999999999999, 0, "Fig is a sweet and soft fruit. It is considered a rich source of nutrients. Fig is abundant in terms of dietary fiber, vitamins (A, B6, C, and K), minerals (potassium, calcium, iron, and magnesium), and antioxidants. Additionally, figs naturally contain sugar.", 0.20000000000000001, 7, "Fig", "../../../images/foodimages/incir.jfif", 1.2 },
                    { 79, 100.0, 93.0, 19.800000000000001, 0, "Mulberry is a fruit that is especially grown in hot climates. Mulberries are usually black in color and have a small, round structure. It is a highly nutritious fruit with its rich content of nutrients.", 1.1000000000000001, 7, "Mulberry", "../../../images/foodimages/karadut.jfif", 6.9000000000000004 },
                    { 80, 100.0, 93.0, 5.0, 0, "Watermelon is a summer fruit that is consumed. It is low in calories due to its high water content. It contains antioxidants such as vitamin C, vitamin A, and lycopene. It also provides minerals like potassium, magnesium, and B vitamins. It supports digestive health, promotes hydration, and offers some health benefits. However, it can rapidly increase blood sugar, so individuals with diabetes should exercise caution.", 0.0, 7, "Watermelon", "../../../images/foodimages/karpuz.jfif", 1.0 },
                    { 81, 100.0, 28.0, 6.0, 0, "Cantaloupe is a fruit that grows in the summer season. It is rich in nutritional values and is a low-calorie fruit. The carbohydrates it contains provide energy to the body. Additionally, cantaloupe is also rich in fiber, contributing to digestive health.", 0.0, 7, "Cantaloupe", "../../../images/foodimages/kavun.jfif", 1.0 },
                    { 82, 100.0, 54.0, 12.0, 0, "Apricot is a fiber-rich fruit that supports digestive health. It also contains vitamins A, C, E, K and minerals such as potassium, iron, and magnesium. These nutrients support the health of bones and tissues, strengthen the immune system, and aid in proper bodily functions.", 0.0, 7, "Apricot", "../../../images/foodimages/kayısı.jfif", 1.0 },
                    { 83, 100.0, 57.0, 13.0, 0, "Cherry: Small, round, red fruit. Nutritional values: Vitamin C, Vitamin A, Vitamin K, potassium, iron, manganese.", 0.0, 7, "Cherry", "../../../images/foodimages/kiraz.jfif", 1.0 },
                    { 84, 100.0, 17.0, 3.2000000000000002, 0, "Lemon is a fruit belonging to the citrus family and is generally known for its pleasant aroma and sour taste. In terms of nutritional value, lemons are low in calories and rich in vitamin C, fiber, and some minerals.", 0.0, 7, "Lemon", "../../../images/foodimages/limon.jfif", 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodID", "Amount", "Calorie", "Carbonhydrate", "Counter", "Description", "Fat", "Food Category ID", "Food Name", "Food Picture", "Protein" },
                values: new object[,]
                {
                    { 85, 100.0, 6.0, 8.0, 0, "Mandarin is a fruit belonging to the citrus family and is commonly consumed during the winter season. Mandarin is rich in various nutrients such as vitamin C, fiber, potassium, and antioxidants. It is also known as a low-calorie fruit. Vitamin C supports the immune system, while fiber promotes digestive health and provides a feeling of fullness. Potassium helps maintain normal muscle function, blood pressure, and fluid balance in the body. Antioxidants can help reduce the effects of harmful free radicals on cells.", 0.0, 7, "Mandarin Orange", "../../../images/foodimages/mandalina.jfif", 1.0 },
                    { 86, 100.0, 90.0, 21.0, 0, "Nutritional values are values that provide information about the nutrients present in food. These values are important for understanding the impact of food on health, creating a balanced diet plan, and meeting the body's nutritional needs. ", 0.0, 7, "Banana", "../../../images/foodimages/muz.jfif", 1.0 },
                    { 87, 100.0, 77.0, 14.699999999999999, 0, "Pomegranate, which belongs to the Punica genus in the order Cucurbitales, is a fruit known for its unique taste and flavor. It is also a highly nutritious fruit. Its key nutritional components include vitamin C, vitamin B, potassium, fiber, and antioxidants.", 0.69999999999999996, 7, "Pomegranate", "../../../images/foodimages/nar.jfif", 0.80000000000000004 },
                    { 88, 100.0, 41.0, 9.0, 0, "Orange is a fruit belonging to the citrus family. It contains a high amount of vitamin C, which strengthens the immune system. Additionally, it is rich in fiber, which regulates the digestive system and provides a feeling of satiety.", 0.0, 7, "Orange", "../../../images/foodimages/portakal.jfif", 1.0 },
                    { 89, 100.0, 49.0, 11.0, 0, "Peach is a sweet and juicy fruit. It contains nutrients such as vitamin C, vitamin A, vitamin E, vitamin K, potassium, magnesium, and iron. Additionally, it is rich in dietary fiber. The nutritional values of peach provide several benefits, including strengthening the immune system, supporting eye health, regulating blood pressure, promoting bone health, and aiding digestion.", 0.0, 7, "Peach", "../../../images/foodimages/şeftali.jfif", 1.0 },
                    { 90, 100.0, 74.0, 17.0, 0, "Grape is a fruit belonging to the Vitis genus and is widely cultivated worldwide. It usually comes in two different varieties, sweet and sour. Grape is a nutritious fruit that contains various vitamins, minerals, and other essential nutrients.", 0.0, 7, "Grape", "../../../images/foodimages/üzüm.jfif", 1.0 },
                    { 91, 100.0, 57.0, 13.0, 0, "Cherry is a fruit belonging to the Prunus genus and is generally part of the cherry family. It comes in sweet and sour varieties. Cherries are small-sized, bright red in color, juicy, and have a tart taste.", 0.0, 7, "Sour Cherry", "../../../images/foodimages/vişne.jfif", 1.0 },
                    { 92, 100.0, 136.0, 24.800000000000001, 0, "Lentil soup is a soup whose main ingredient is lentils; it can be vegetarian or contain meat and use brown, red, yellow, green or black lentils, with or without shells. The yellow and red lentils, which have been dehulled, will be crushed as they cook, making a thick soup.", 0.5, 8, "Lentil soup", "../../../images/foodimages/LentilSoup.jfif", 7.2999999999999998 },
                    { 93, 100.0, 66.359999999999999, 9.1400000000000006, 0, "Tomato soup is a soup whose main ingredient is tomato. It can be served hot or cold and can be made in a variety of ways. Its texture can be smooth and there are also recipes that include tomato chunks, cream, chicken or vegetable stock, noodles, other vegetable chunks, and meatballs.", 2.2999999999999998, 8, "Tomato soup", "../../../images/foodimages/Tomatosoup.jfif", 2.2999999999999998 },
                    { 94, 100.0, 76.0, 5.0999999999999996, 0, "Cream of mushroom soup is a simple type of soup in which a basic roux is thinned with cream or milk and then mushrooms and/or mushroom broth is added. It is known as a common type of condensed canned soup in North America..", 4.0, 8, "Mushroom soup", "../../../images/foodimages/MushroomSoup.jfif", 2.1000000000000001 },
                    { 95, 250.0, 115.0, 16.0, 0, "Highland soup or yoghurt soup is a soup whose most important ingredient is yoghurt. It is prepared and consumed in every region of Turkey.", 4.0, 8, "Spring soup", "../../../images/foodimages/SpringSoup.jfif", 3.6000000000000001 },
                    { 96, 250.0, 192.0, 13.9, 0, "Various vegetables combine in a single dish, turning into one of the most satisfying recipes. It is flavored with potatoes, eggplant, zucchini, green peppers, tomatoes and spices.", 7.7000000000000002, 9, "Types of Food", "../../../images/foodimages/TypesofFood.jfif", 3.7999999999999998 },
                    { 97, 250.0, 250.0, 45.100000000000001, 0, "Dry beans are a cooked bean dish in Turkish cuisine. It is made with white beans and olive oil and mostly uses onion and tomato paste. Preferably vegetables or meat can be added to the dish. Dried beans are served with rice pilaf or bulgur pilaf. It can be consumed by adding bread to its water.", 0.63, 9, "Dry bean Meal", "../../../images/foodimages/DryBeanmeal.jfif", 17.5 },
                    { 98, 120.0, 148.80000000000001, 45.100000000000001, 0, "Chicken doner kebab is made from chicken meat. Chicken doner, which finds its place in Turkish cuisine, is one of the most frequently consumed fast-food products in Turkey.", 19.600000000000001, 9, "Chicken Doner", "../../../images/foodimages/ChickenDoner.jfif", 20.600000000000001 },
                    { 99, 250.0, 301.0, 19.600000000000001, 0, "Döner or doner kebab is a dish unique to Turkish cuisine, in which pieces of meat seasoned with tallow and local spices are cooked on a skewer and hung upright in front of a wood fire.", 46.5, 9, "Meat Doner", "../../../images/foodimages/MeatDoner.jfif", 29.600000000000001 },
                    { 100, 250.0, 191.0, 8.6999999999999993, 0, "Karnıyarık is one of the main eggplant dishes of Turkish cuisine. In addition to eggplant, which is the main ingredient, onions, peppers, tomatoes and minced meat are also used during preparation. A similar eggplant dish is imambayildi. The difference of Imambayildi from Karnıyarık is that there is no meat in it and it is served cold.", 12.199999999999999, 9, "Karniyarık Meal", "../../../images/foodimages/KarniyarıkMeal.jfif", 11.1 },
                    { 101, 250.0, 312.0, 37.700000000000003, 0, "Hamburger, or simply Burger, is a type of sandwich made with a meatball, American cheese, and lettuce placed between two slices of round sandwich bread. It is usually served with the addition of different ingredients such as ketchup, mayonnaise, pickles, onions, tomatoes, mustard and so on.", 11.199999999999999, 9, "Hamburger", "../../../images/foodimages/Hamburger.jfif", 13.300000000000001 },
                    { 102, 240.0, 423.0, 11.0, 0, "Cooking meat and vegetables in a pan at high heat is called saute. Sauteing, which is a cooking method, is prepared by cooking meat and vegetables in a short time by stirring constantly. It is very important that the materials to be used while sautéing are chopped into small pieces in the form of cubes.", 22.0, 9, "Chicken Saute", "../../../images/foodimages/ChickenSaute.jfif", 42.0 },
                    { 103, 100.0, 88.0, 1.7, 0, "Nutritional values such as the taste of the dish made from beef are also important for the human body.", 3.5, 9, "Boiled Veal", "../../../images/foodimages/BoiledVeal.jfif", 12.0 },
                    { 104, 100.0, 257.0, 30.800000000000001, 0, "Kidney beans provide many health benefits. It has benefits such as regulating digestion, lowering blood pressure, increasing muscle mass in the body, and reducing the risk of diabetes. It also contributes to mental health by strengthening the bones.", 10.1, 9, "Kidney Beans Meal", "../../../images/foodimages/KidneyBeansMeal.jfif", 11.5 },
                    { 105, 100.0, 157.0, 30.5, 0, "Pasta is also very rich in vitamins A, B1, B2, iron, calcium, phosphorus, potassium and protein. It is oil free. It has a cholesterol-lowering effect as it contains very little (1-1,5%) minor fat components and a high rate of linoleic fatty acid.Complex carbohydrates in pasta keep you full because they mix slowly into the blood.", 0.29999999999999999, 10, "Pasta", "../../../images/foodimages/Pasta.jfif", 5.7999999999999998 },
                    { 106, 100.0, 114.0, 18.100000000000001, 0, "Bulgur, which contains vitamin B1, magnesium and folate, plays an important role for the nervous system and digestive system. Because bulgur contains high levels of minerals and vitamins, it ensures regular and healthy functioning of the intestines. Bulgur, which prevents constipation, also relaxes the mind and provides high energy.", 3.2999999999999998, 10, "Bulgur Rice", "../../../images/foodimages/BulgurRice.jfif", 2.7000000000000002 },
                    { 107, 100.0, 162.0, 24.699999999999999, 0, "All rice varieties are a great source of minerals such as calcium and iron; It is also rich in vitamins such as niacin, vitamin D, thiamine, fiber and riboflavin. Rice is easy to digest and has less saturated fat and good cholesterol compared to other foods. Therefore, it is good for heart health.", 5.7999999999999998, 10, "Rice", "../../../images/foodimages/Rice.jfif", 2.0 },
                    { 108, 100.0, 31.0, 3.7999999999999998, 0, "Although each type of leafy vegetable has different health benefits, they are all low-calorie and high-fiber foods. This means you will fill your stomach with fewer calories. Eating foods that contain fiber can also improve the health of the digestive system. Black lettuce, kale and spinach are rich in vitamins A, C, E and K. Arugula and mustard vegetables also provide most of the B vitamins.", 1.0, 11, "Seasonal Salad", "../../../images/foodimages/SeasonalSalad.jfif", 1.3 },
                    { 109, 100.0, 124.0, 15.800000000000001, 0, "According to research, properly planned vegetarian diets are considered healthy. Additionally, it is nutritionally adequate and may provide health benefits in the prevention and treatment of certain diseases.", 5.4000000000000004, 11, "Vegetarian Salad", "../../../images/foodimages/VegetarianSalad.jfif", 2.7999999999999998 },
                    { 110, 100.0, 117.0, 5.0, 0, "Thanks to the Omega 3 fatty acids in it, it controls the cholesterol and balances the heart rhythm. Consumption of tuna salad containing 100 to 300 grams of tuna daily meets the amount of Omega-3 we need and contributes to the strengthening of immunity. Omega 3 is also a skin friend.", 8.0999999999999996, 11, "Tuna Salad", "../../../images/foodimages/TunaSalad.jfif", 5.7999999999999998 },
                    { 111, 100.0, 65.0, 3.2000000000000002, 0, "Chicken shepherd's salad is one of the most preferred salad varieties of dieters. Especially the grilled salad with the lean part of the fish helps to keep you full for longer than other salads. It can be preferred as both a light and nutritious meal.", 1.3, 11, "Chicken Salad", "../../../images/foodimages/ChickenSalad.jfif", 9.6999999999999993 },
                    { 112, 100.0, 105.0, 21.5, 0, "Of course, rice pudding is a dessert that conquers hearts not only with its historical features, but also with its benefits to human health. Studies show that the B vitamins in milk are extremely beneficial for the health of the stomach and brain, especially for reasons such as the benefit of being alkaline, the effect of sugar on happiness.", 1.3, 12, "Rice Pudding", "../../../images/foodimages/RicePudding.jfif", 1.7 },
                    { 113, 100.0, 272.0, 45.899999999999999, 0, "Şekerpare is a sherbet and pasty dessert from Turkish cuisine. It takes place in Ottoman cuisine. After the dough is prepared, before putting the Şekerpare, which is divided into small pieces and separated in a round shape, into the oven, unsalted hazelnuts, peanuts, almonds, walnuts, etc. one each of the dried nuts is placed.", 8.9000000000000004, 12, "Sugar Pare", "../../../images/foodimages/SugarPare.jfif", 2.6000000000000001 },
                    { 114, 100.0, 319.0, 24.699999999999999, 0, "Also known as San Sebastian Cheesecake(Basque Cheesecake)(La Vina San Sebastian Burnt Cheesecake). This Baked Cheesecake recipe was first made in the 1990s at a small patisserie called La Vina located at 31 de Agosto Street in the old quarter of the city of San Sebastián.", 22.199999999999999, 12, "San Sebastian Dessert", "../../../images/foodimages/SanSebastianDessert.jfif", 5.2000000000000002 },
                    { 115, 100.0, 412.0, 49.299999999999997, 0, "Baklava is an important dumpling that has a place in Turkish, Middle Eastern, Balkan and South Asian cuisines. It is made by placing walnuts, pistachios, almonds or hazelnuts, depending on the region, between thin phyllo dough. It is generally sweetened with sugar syrup. Honey syrup can also be used.", 21.399999999999999, 12, "Baklava Dessert", "../../../images/foodimages/BaklavaDessert.jfif", 7.7000000000000002 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "AccountID", "BMI Status", "BMR", "Daily Calorie", "Daily Carbonhydrate", "Daily Fat", "Daily Protein", "Height", "Limit Of Calories", "LimitOfCarbonhydrate", "LimitOfFat", "LimitOfProtein", "Repast", "User BMI", "Weight" },
                values: new object[] { 1, null, null, 0.0, 0.0, 0.0, 0.0, 183.0, 0.0, 0.0, 0.0, 0.0, null, 2.0, 89.0 });

            migrationBuilder.CreateIndex(
                name: "IX_Foods_Food Category ID",
                table: "Foods",
                column: "Food Category ID");

            migrationBuilder.CreateIndex(
                name: "IX_RepastUser_UsersAccountID",
                table: "RepastUser",
                column: "UsersAccountID");

            migrationBuilder.CreateIndex(
                name: "IX_UserFoods_Food ID",
                table: "UserFoods",
                column: "Food ID");

            migrationBuilder.CreateIndex(
                name: "IX_UserFoods_Repast ID",
                table: "UserFoods",
                column: "Repast ID");

            migrationBuilder.CreateIndex(
                name: "IX_UserFoods_UsersAccountID",
                table: "UserFoods",
                column: "UsersAccountID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RepastUser");

            migrationBuilder.DropTable(
                name: "UserFoods");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Repasts");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Food Categories");

            migrationBuilder.DropTable(
                name: "Accounts");
        }
    }
}
