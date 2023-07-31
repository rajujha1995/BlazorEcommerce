namespace BlazorEcommerce.Server.Data;
public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Books",
                    Url = "books"
                },
                new Category
                {
                    Id = 2,
                    Name = "Movies",
                    Url = "movies"
                },
                new Category
                {
                    Id = 3,
                    Name = "Video Games",
                    Url = "video-games"
                }
            );
        modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Discovery of India by Jawaharlal Nehru",
                    Description = "Written by India’s first prime minister when  he was in prison (1942-1946), this book traces India’s   history starting from the Indus Valley Civilization. It   gives a detailed account of the period ranging from the   coming of the Aryans to the establishment of the British  Empire. A recommended read to get a snapshot of India’s  incredibly long past. This book was also produced as an  award-winning television series by Shyam Benegal.",
                    ImageUrl = "https://m.media-amazon.com/images/I/51JTJUe0-+L._SX343_BO1,204,203,200_.jpg",
                    Price = 9.99m,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 2,
                    Title = "Freedom at Midnight by Dominique Lapierre and Larry      Collins",
                    Description = "This book primarily focuses on India’s   independence        movement during 1946 and 1948. The    series of events that   unfold  during  this period are    worthy of this book being     classified as a    historical        one. It is extensively    researched, gives incredible        details that you    never knew    (for instance, do you     know who   actually drew the dividing    line between the   two nations and on  what basis?) and is a   highly    recommended book on India’s    independence and   partition.   The book also    includes interviews   with Lord     Mountbatten, the last viceroy of British     India.",
                    ImageUrl = "https://m.media-amazon.com/images/I/51Frw6rTpGL._SX322_BO1,204,203,200_.jpg",
                    Price = 8.99m,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 3,
                    Title = "The Argumentative Indian by Amartya Sen",
                    Description = "Written by the Nobel Prize winning economist Amartya Sen, this book is essentially a series of poignant essays narrating India’s history and how that history has influenced and shaped its cultural identity. Sen talks about how India has had a long history of public debate (in all spheres of life) and how heterodoxy was prevalent in Indian society centuries ago. This vibrant past is something that Sen believes we all should know about – considering that it can have a deep impact on the way we embrace our future.",
                    ImageUrl = " https://m.media-amazon.com/images/I/61lVEuWnW8L._SX325_BO1,204,203,200_.jpg",
                    Price = 7.99m,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 4,
                    Title = "The Wonder That Was India by A L Basham",
                    Description = "This book is considered a useful source of history for aspirants to the Indian civil services. Basham’s popular work covers the period between ancient India and the arrival of the Muslims. It covers details of the Harappan and Mohenjodaro findings and then dwells on the now-controversial Aryan invasion theory. Basham also studies the interpretations of the Rig Veda and other Sanskrit texts to give a better understanding of the country’s past.",
                    ImageUrl = " https://m.media-amazon.com/images/I/41CTXwZtZAL._SX329_BO1,204,203,200_.jpg",
                    Price = 6.99m,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 5,
                    Title = "India: A history by John Keay",
                    Description = "John Keay is an English journalist and author specialising in writing popular histories about India, often with a particular focus on their colonisation and exploration by Europeans. In “India: A history”, John provides a panaromic view starting from the cities of Harappa and Mohenjodaro of the Indus Valley civilizations all the way to the current modern India. This book is considered by many as a perfect textbook for any student of India.",
                    ImageUrl = " https://m.media-amazon.com/images/I/51ylP4+2y2L._SX327_BO1,204,203,200_.jpg",
                    Price = 5.99m,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 6,
                    CategoryId = 2,
                    Price = 2.99m,
                    Title = "Toy Story",
                    Description = "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg",

                },
                new Product
                {
                    Id = 7,
                    CategoryId = 3,
                    Title = "Half-Life 2",
                    Price = 49.99m,
                    Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",

                },
                new Product
                {
                    Id = 8,
                    CategoryId = 3,
                    Title = "Diablo II",
                    Price = 9.99m,
                    Description = "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png",
                },
                new Product
                {
                    Id = 9,
                    CategoryId = 3,
                    Price = 14.99m,
                    Title = "Day of the Tentacle",
                    Description = "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg",
                },
                new Product
                {
                    Id = 10,
                    CategoryId = 3,
                    Price = 159.99m,
                    Title = "Xbox",
                    Description = "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg",
                },
                new Product
                {
                    Id = 11,
                    CategoryId = 3,
                    Price = 79.99m,
                    Title = "Super Nintendo Entertainment System",
                    Description = "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg",
                },
                new Product
                {
                    Id = 12,
                    CategoryId = 2,
                    Price = 4.99m,
                    Title = "The Matrix",
                    Description = "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg",
                },
                new Product
                {
                    Id = 13,
                    CategoryId = 2,
                    Price = 3.99m,
                    Title = "Back to the Future",
                    Description = "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg",
                }
            );
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
}
