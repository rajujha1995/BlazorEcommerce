namespace BlazorEcommerce.Server.Data;
public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Discovery of India by Jawaharlal Nehru",
                    Description = "Written by India’s first prime minister when    he was in prison (1942-1946), this book traces India’s     history starting from the Indus Valley Civilization. It     gives a detailed account of the period ranging from the     coming of the Aryans to the establishment of the British    Empire. A recommended read to get a snapshot of India’s    incredibly long past. This book was also produced as an    award-winning television series by Shyam Benegal.",
                    ImageUrl = "https://m.media-amazon.com/images/I/51JTJUe0-+L._SX343_BO1,204,203,200_.jpg",
                    Price = 9.99m
                },
                new Product
                {
                    Id = 2,
                    Title = "Freedom at Midnight by Dominique Lapierre and Larry Collins",
                    Description = "This book primarily focuses on India’s   independence  movement during 1946 and 1948. The series of    events that unfold  during this period are worthy of this  book being classified as a  historical one. It is    extensively researched, gives incredible  details that you     never knew (for instance, do you know who   actually drew   the dividing line between the two nations and on    what  basis?) and is a highly recommended book on India’s      independence and partition. The book also includes     interviews     with Lord Mountbatten, the last viceroy of   British India.",
                    ImageUrl = "https://m.media-amazon.com/images/I/51Frw6rTpGL._SX322_BO1,204,203,200_.jpg",
                    Price = 8.99m
                },
                new Product
                {
                    Id = 3,
                    Title = "The Argumentative Indian by Amartya Sen",
                    Description = "Written by the Nobel Prize winning economist       Amartya Sen, this book is essentially a series of poignant    essays narrating India’s history and how that history has      influenced and shaped its cultural identity. Sen talks     about how    India has had a long history of public debate  (in all spheres     of life) and how heterodoxy was  prevalent in Indian society     centuries ago.  This vibrant  past is something that Sen believes     we all should know  about – considering that it can have a deep     impact on    the way we embrace our future.",
                    ImageUrl = "	https://m.media-amazon.com/images/I/61lVEuWnW8L._SX325_BO1,204,203,200_.jpg",
                    Price = 7.99m
                },
                new Product
                {
                    Id = 4,
                    Title = "The Wonder That Was India by A L Basham",
                    Description = "This book is considered a useful source of   history   for aspirants to the Indian civil services.     Basham’s popular  work covers the period between ancient    India and the arrival of  the Muslims. It covers details of    the Harappan and Mohenjodaro   findings and then dwells on     the now-controversial Aryan invasion   theory. Basham also  studies the interpretations of the Rig Veda   and other  Sanskrit texts to give a better understanding of the     country’s past.",
                    ImageUrl = "	https://m.media-amazon.com/images/I/41CTXwZtZAL._SX329_BO1,204,203,200_.jpg",
                    Price = 6.99m
                },
                new Product
                {
                    Id = 5,
                    Title = "India: A history by John Keay",
                    Description = "John Keay is an English journalist and author specialising in writing popular histories about India,  often   with a particular focus on their colonisation and exploration by   Europeans. In “India: A history”, John    provides a panaromic  view starting from the cities of     Harappa and Mohenjodaro of the  Indus Valley civilizations  all the way to the current modern     India. This book is    considered by many as a perfect textbook for     any student    of India.",
                    ImageUrl = "	https://m.media-amazon.com/images/I/51ylP4+2y2L._SX327_BO1,204,203,200_.jpg",
                    Price = 5.99m
                }
            );
    }

    public DbSet<Product> Products { get; set; }
}
